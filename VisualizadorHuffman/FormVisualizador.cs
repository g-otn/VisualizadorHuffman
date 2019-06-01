using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizadorHuffman
{
    public partial class FormVisualizador : Form
    {
        private int caractereAtual; // Guarda o progresso de leitura do rtbEntrada e inserção de folhas no trvArvore
        private enum EstadoAlgoritmo { Parado, LendoEntrada, ConstruindoArvore, GerandoSaida };
        private EstadoAlgoritmo estadoAtual = EstadoAlgoritmo.Parado;


        public FormVisualizador()
        {
            InitializeComponent();
            ActiveControl = rtbEntrada;
        }



        #region Eventos dos controles de entrada

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            if (ofdArquivoEntrada.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoArquivo.ForeColor = SystemColors.ControlText;
                txtCaminhoArquivo.Text = ofdArquivoEntrada.FileName;
                rtbEntrada.ForeColor = SystemColors.ControlText;
                rtbEntrada.Text = File.ReadAllText(ofdArquivoEntrada.FileName, Encoding.GetEncoding(1252));
                SubstituirWindows1252InvalidosDaEntrada();
            }
        }

        private void txtCaminhoArquivo_Leave(object sender, EventArgs e)
        {
            if (txtCaminhoArquivo.Text != ofdArquivoEntrada.FileName)
            {
                try
                {
                    rtbEntrada.Text = File.ReadAllText(txtCaminhoArquivo.Text, Encoding.GetEncoding(1252));
                    SubstituirWindows1252InvalidosDaEntrada();
                    ofdArquivoEntrada.FileName = txtCaminhoArquivo.Text; // Permite abrir outro arquivo se o txtCaminhoArquivo.Text for modificado novamente
                    txtCaminhoArquivo.ForeColor = SystemColors.ControlText;
                }
                catch
                {
                    txtCaminhoArquivo.ForeColor = Color.Red;
                }
            }
        }

        private void rtbEntrada_TextChanged(object sender, EventArgs e)
        {
            if (rtbEntrada.ForeColor != SystemColors.GrayText)
            {
                int bytes = Encoding.GetEncoding(1252).GetByteCount(rtbEntrada.Text);
                lblInfoEntrada.Text = $"Entrada: {bytes} bytes, {bytes * 8} bits";
            }
        }

        #endregion



        #region Eventos dos controles de controle

        private void btnIniciarParar_Click(object sender, EventArgs e)
        {
            if (btnIniciarParar.Text == "Iniciar") // Iniciar
            {
                if (rtbEntrada.ForeColor == SystemColors.GrayText)
                {
                    MessageBox.Show(this, "Digite algo na caixa de texto de entrada!", "Impossível iniciar algoritmo");
                    return;
                }

                // Reiniciar variáveis
                caractereAtual = 0;
                estadoAtual = EstadoAlgoritmo.Parado;
                avancarEstadoDoAlgoritmo();

                // Reiniciar controles
                btnIniciarParar.Text = "Parar";
                btnPausarContinuar.Text = "Pausar";
                btnPausarContinuar.Enabled = true;
                btnProximoPasso.Enabled = true;
                tkbIntervaloPassos_Scroll(null, null); // Atualiza timerPasso.Interval e lblVelocidade.Text

                trvArvore.Nodes.Clear();
                dgvCaracteres.Rows.Clear();

                rtbSaidaBinario.Clear();
                rtbSaidaBytes.Clear();
                lblInfoDiferenca.Text = "";
                lblInfoSaida.Text = "Saída: ";

                // Preparar controles
                btnAbrirArquivo.Enabled = false;
                txtCaminhoArquivo.ReadOnly = true;
                rtbEntrada.ReadOnly = true;
                rtbEntrada.SelectionStart = 0;
                rtbEntrada.SelectionLength = 0;
                SubstituirWindows1252InvalidosDaEntrada();

                // Iniciar passos
                timerPasso_Tick(null, null);
                timerPasso.Start();
            }
            else                                    // Parar
            {
                // Reiniciar variáveis
                estadoAtual = EstadoAlgoritmo.Parado;
                lblEstado.Text = "Estado: Parado";

                // Reiniciar controles
                timerPasso.Stop();

                btnAbrirArquivo.Enabled = true;
                txtCaminhoArquivo.ReadOnly = false;
                rtbEntrada.ReadOnly = false;
                rtbEntrada.SelectAll();
                rtbEntrada.SelectionBackColor = SystemColors.Window;

                btnIniciarParar.Text = "Iniciar";
                btnPausarContinuar.Text = "Pausar";
                btnPausarContinuar.Enabled = false;
                btnProximoPasso.Enabled = false;
            }
        }

        private void btnPausarContinuar_Click(object sender, EventArgs e)
        {
            if (btnIniciarParar.Text == "Iniciar")
            {
                return;
            }

            if (btnPausarContinuar.Text == "Pausar") // Pausar
            {
                timerPasso.Stop();

                btnPausarContinuar.Text = "Continuar";
            }
            else                                     // Continuar
            {
                timerPasso.Start();

                btnPausarContinuar.Text = "Pausar";
            }

        }

        private void btnProximoPasso_Click(object sender, EventArgs e)
        {
            if (btnIniciarParar.Text == "Iniciar")
            {
                return;
            }

            btnPausarContinuar.Text = "Continuar";
            timerPasso.Stop();           // Pausar passos
            timerPasso_Tick(null, null); // Realizar próximo passo

        }

        private void rtbEntrada_Enter(object sender, EventArgs e)
        {
            if (rtbEntrada.ForeColor == SystemColors.GrayText && rtbEntrada.Text == "Digite alguma coisa...")
            {
                rtbEntrada.ForeColor = SystemColors.WindowText;
                rtbEntrada.Clear();
            }
        }

        private void rtbEntrada_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbEntrada.Text))
            {
                rtbEntrada.ForeColor = SystemColors.GrayText;
                rtbEntrada.Text = "Digite alguma coisa...";
            }
        }

        private void tkbIntervaloPassos_Scroll(object sender, EventArgs e)
        {
            timerPasso.Interval = tkbIntervaloPassos.Maximum + 25 - tkbIntervaloPassos.Value;
            lblVelocidade.Text = "Velocidade:\n" + timerPasso.Interval + "ms / caractere";
        }

        #endregion



        #region Métodos do algoritmo

        private void timerPasso_Tick(object sender, EventArgs e)
        {
            switch (estadoAtual)
            {
                case EstadoAlgoritmo.LendoEntrada:
                    LerEntrada();
                    break;
                case EstadoAlgoritmo.ConstruindoArvore:
                    ConstruirArvore();
                    break;
                case EstadoAlgoritmo.GerandoSaida:
                    break;
            }
        }

        private void avancarEstadoDoAlgoritmo()
        {
            switch (estadoAtual)
            {
                case EstadoAlgoritmo.Parado:
                    estadoAtual = EstadoAlgoritmo.LendoEntrada;
                    lblEstado.Text = "Estado: Lendo entrada e contando frequência";
                    break;
                case EstadoAlgoritmo.LendoEntrada:
                    estadoAtual = EstadoAlgoritmo.ConstruindoArvore;
                    lblEstado.Text = "Estado: Construindo árvore";
                    break;
                case EstadoAlgoritmo.ConstruindoArvore:
                    estadoAtual = EstadoAlgoritmo.GerandoSaida;
                    lblEstado.Text = "Estado: Percorrendo árvore e gerando saída";
                    break;
                case EstadoAlgoritmo.GerandoSaida:
                    estadoAtual = EstadoAlgoritmo.Parado;
                    lblEstado.Text = "Estado: Saída gerada, fim do algoritmo";
                    break;
            }
        }

        private void LerEntrada()
        {
            // Termina o estado atual (EstadoAlgoritmo.LendoEntrada) do algoritmo
            if (caractereAtual == rtbEntrada.Text.Length)
            {
                // Limpa seleção do última caractere
                rtbEntrada.Select(caractereAtual - 1, 1);
                rtbEntrada.SelectionColor = SystemColors.ControlText;
                rtbEntrada.SelectionBackColor = SystemColors.Window;
                dgvCaracteres.ClearSelection();

                // Passa ao algoritmo para o próximo estado
                avancarEstadoDoAlgoritmo();

                return; // Todos os caracteres já foram analizados
            }

            try
            {
                LockWindowUpdate(rtbEntrada.Handle);
                LockWindowUpdate(trvArvore.Handle);

                // Remove o destaque do caractere anterior
                if (caractereAtual != 0)
                {
                    rtbEntrada.Select(caractereAtual - 1, 1);
                    rtbEntrada.SelectionColor = SystemColors.ControlText;
                    rtbEntrada.SelectionBackColor = SystemColors.Window;
                }

                // Destaca o caractere atual no rtbEntrada
                rtbEntrada.Select(caractereAtual, 1);
                rtbEntrada.SelectionColor = SystemColors.HighlightText;
                rtbEntrada.SelectionBackColor = Color.LightSeaGreen;

                rtbEntrada.ScrollToCaret();
            }
            finally
            {
                LockWindowUpdate(IntPtr.Zero);

                // Adiciona a linha do caractere ou incrementa a frequência
                char caractere = rtbEntrada.Text[caractereAtual];
                int i;

                //                TreeNode treeNode = new TreeNode();
                //                treeNode.Tag = new Folha(caractere, /*frequencia*/);

                // Aumenta o valor da coluna frequência se o caractere já existe em uma linha
                for (i = 0; i < dgvCaracteres.RowCount; i++)
                {                    
                    if (caractere == Convert.ToInt32(dgvCaracteres.Rows[i].Cells[0].Tag))
                    {
                        dgvCaracteres.Rows[i].Cells[1].Value = (int)dgvCaracteres.Rows[i].Cells[1].Value + 1;
                        dgvCaracteres.Rows[i].Selected = true;
                        break;
                    }
                }

                // Cria uma nova linha se o caractere ainda não existe no dgvCaracteres
                if (i == dgvCaracteres.RowCount)
                {
                    dgvCaracteres.Rows.Add(null, 1); // Coluna de frequência

                    dgvCaracteres.Rows[dgvCaracteres.RowCount - 1].Cells[0].Tag = (int)caractere;

                    // Coluna de Caractere
                    if (caractere == '\n')
                    {
                        dgvCaracteres.Rows[dgvCaracteres.RowCount - 1].Cells[0].Value = "Nova Linha";
                    }
                    else if (caractere == ' ')
                    {
                        dgvCaracteres.Rows[dgvCaracteres.RowCount - 1].Cells[0].Value = "Espaço";
                    }
                    else if (char.IsControl(caractere)) // Mostra caracteres que não são visíveis
                    {
                        dgvCaracteres.Rows[dgvCaracteres.RowCount - 1].Cells[0].Value = $"({(int)caractere})";
                    }
                    else
                    {
                        dgvCaracteres.Rows[dgvCaracteres.RowCount - 1].Cells[0].Value = caractere;
                    }



                    dgvCaracteres.Rows[dgvCaracteres.RowCount - 1].Selected = true;

                    // DEBUG: Mostra o código Windows-1252 do caractere
                    byte codigoWindows1252DoCaractereUnicode = Encoding.Convert(Encoding.Unicode, Encoding.GetEncoding(1252), Encoding.Unicode.GetBytes(caractere.ToString()))[0];
                    dgvCaracteres.Rows[dgvCaracteres.RowCount - 1].Cells[2].Value = codigoWindows1252DoCaractereUnicode;
                }

                // Ordena as linhas dos dgvCaracteres baseado na coluna de Frequência
                DataGridViewColumn frequencias = dgvCaracteres.Columns[1];
                dgvCaracteres.Sort(frequencias, ListSortDirection.Descending);


                caractereAtual++;
            }
        }

        private void ConstruirArvore()
        {
            if (trvArvore.GetNodeCount(false) == 0) // Não tem nem as folhas "soltas" nem a árvore sendo montada
            {
                // Insere todas as folhas
                TreeNode raiz = new TreeNode("Não montados");
                foreach (DataGridViewRow linha in dgvCaracteres.Rows)
                {
                    string nomeCaractere = linha.Cells[0].Value.ToString();
                    int valorCaractere = Convert.ToInt32(linha.Cells[0].Tag);
                    int frequencia = Convert.ToInt32(linha.Cells[1].Value);
                    TreeNode no = new TreeNode();
                    no.Text = $"'{nomeCaractere}' ({frequencia})";
                    no.ToolTipText = $"Lado: 0/1 Caractere: {nomeCaractere} Frequência: {frequencia}";
                    no.Name = valorCaractere.ToString();
                    raiz.Nodes.Add(no);
                }
                trvArvore.Nodes.Add(raiz);
            }
        }

        #endregion



        #region Outros Métodos

        private void lnkGitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/g-otn/VisualizadorHuffman");
        }

        // Impede a maior parte do flickering no rtbEntrada
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(IntPtr windowLock);

        private void SubstituirWindows1252InvalidosDaEntrada()
        {
            // Substitui qualquer caractere inserido que não pode ser representado pelo Windows-1252 por '?'
            byte[] bytesEntradaEmWindows1252 = Encoding.Convert(Encoding.Unicode, Encoding.GetEncoding(1252), Encoding.Unicode.GetBytes(rtbEntrada.Text));
            rtbEntrada.Text = Encoding.GetEncoding(1252).GetString(bytesEntradaEmWindows1252);
        }

        #endregion
    }
}
