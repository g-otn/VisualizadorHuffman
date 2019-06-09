using System;
using System.Collections;
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
        private enum EstadoAlgoritmo { Parado, LendoEntrada, ConstruindoArvore, GerandoCodigo, GerandoSaida };
        private EstadoAlgoritmo estadoAtual = EstadoAlgoritmo.Parado;

        private int caractereAtual; // Guarda o progresso de leitura do rtbEntrada

        // Usado para guardar a cor dos nós que foram reposicionados no trvArvore
        private TreeNode primeiro = new TreeNode();
        private TreeNode segundo = new TreeNode();

        private string ultimoCaminho = "";


        public FormVisualizador()
        {
            InitializeComponent();
            trvArvore.TreeViewNodeSorter = new OrganizarNoPorFrequenciaOuPeso();
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
                    rtbEntrada.ForeColor = SystemColors.ControlText;
                    rtbEntrada.Text = File.ReadAllText(txtCaminhoArquivo.Text, Encoding.GetEncoding(1252));
                    SubstituirWindows1252InvalidosDaEntrada();
                    ofdArquivoEntrada.FileName = txtCaminhoArquivo.Text; // Permite abrir outro arquivo se o txtCaminhoArquivo.Text for modificado novamente
                    txtCaminhoArquivo.ForeColor = SystemColors.ControlText;
                }
                catch
                {
                    rtbEntrada.ForeColor = SystemColors.GrayText;
                    txtCaminhoArquivo.ForeColor = Color.Red;
                }
            }
        }

        private void rtbEntrada_TextChanged(object sender, EventArgs e)
        {
            if (rtbEntrada.ForeColor != SystemColors.GrayText)
            {
                // Troca o tamanho da fonte baseado no tamanho do texto
                int larguraTexto = 1 + TextRenderer.MeasureText(rtbEntrada.Text.Replace("\n", string.Empty), new Font("Consolas", 20)).Width;
                if (larguraTexto < rtbEntrada.Width * 2.7)
                {
                    rtbEntrada.Font = new Font("Consolas", 20);
                }
                else
                {
                    rtbEntrada.Font = new Font("Consolas", 10);
                }

                // Atualiza contagem de bytes da entrada
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
                rtbSaidaBytes1252.Clear();
                rtbSaidaBytesUTF8.Clear();
                lblInfoDiferenca.Text = "";
                lblInfoSaida.Text = "Saída: ";

                // Preparar controles
                btnAbrirArquivo.Enabled = false;
                txtCaminhoArquivo.Enabled = false;
                rtbEntrada.ReadOnly = true;
                trocarTamanhoFonteSaida();
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
                txtCaminhoArquivo.Enabled = true;
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
                rtbEntrada.Text = "Digite alguma coisa...";
                rtbEntrada.ForeColor = SystemColors.GrayText;
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
                case EstadoAlgoritmo.GerandoCodigo:
                    GerarCodigo();
                    break;
                case EstadoAlgoritmo.GerandoSaida:
                    GerarSaida();
                    break;
                case EstadoAlgoritmo.Parado:
                    btnIniciarParar_Click(null, null);
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
                    estadoAtual = EstadoAlgoritmo.GerandoCodigo;
                    lblEstado.Text = "Estado: Gerando o código de cada caractere";
                    break;
                case EstadoAlgoritmo.GerandoCodigo:
                    estadoAtual = EstadoAlgoritmo.GerandoSaida;
                    lblEstado.Text = "Estado: Gerando saída";
                    caractereAtual = 0;
                    break;
                case EstadoAlgoritmo.GerandoSaida:
                    estadoAtual = EstadoAlgoritmo.Parado;
                    lblEstado.Text = "Estado: Saída gerada, fim do algoritmo";
                    break;
            }
        }



        private void LerEntrada()
        {
            dgvCaracteres.ClearSelection();

            // Termina o estado atual (EstadoAlgoritmo.LendoEntrada) do algoritmo
            if (caractereAtual == rtbEntrada.Text.Length)
            {
                // Limpa seleção do última caractere
                rtbEntrada.Select(caractereAtual - 1, 1);
                rtbEntrada.SelectionColor = SystemColors.ControlText;
                rtbEntrada.SelectionBackColor = SystemColors.Window;

                // Passa ao algoritmo para o próximo estado
                avancarEstadoDoAlgoritmo();
                timerPasso_Tick(null, null); // Realiza o primeiro passo do ConstruirArvore() (criar e inserir as Folhas "soltas")

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
                // Aumenta o valor da coluna frequência se o caractere já existe em uma linha
                for (i = 0; i < dgvCaracteres.RowCount; i++)
                {
                    if (caractere == Convert.ToInt32(dgvCaracteres.Rows[i].Tag))
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
                    dgvCaracteres.Rows[dgvCaracteres.RowCount - 1].Tag = (int)caractere; // Usado para identificação de caracter já existente (inserido)

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

                    dgvCaracteres.Rows[dgvCaracteres.RowCount - 1].Selected = true; // Visualização
                    
                    // Visualização
                    Random random = new Random();
                    Color corAleatoria = Color.FromArgb(25 + random.Next(150), 25 + random.Next(150), 25 + random.Next(150));
                    dgvCaracteres.Rows[dgvCaracteres.RowCount - 1].DefaultCellStyle.ForeColor = corAleatoria;
                }

                // Ordena as linhas dos dgvCaracteres baseado na coluna de Frequência
                DataGridViewColumn frequencias = dgvCaracteres.Columns[1];
                dgvCaracteres.Sort(frequencias, ListSortDirection.Descending);

                caractereAtual++;
            }
        }



        private void ConstruirArvore()
        {
            if (trvArvore.GetNodeCount(false) == 0) // trvArvore.Nodes está vazio (as folhas não foram adicionadas)
            {
                // Insere todas as folhas ordenadas por frêquencia pelo dgvCaracteres no trvArvore
                foreach (DataGridViewRow linha in dgvCaracteres.Rows)
                {
                    string nomeCaractere = linha.Cells[0].Value.ToString();
                    int valorCaractere = Convert.ToInt32(linha.Tag);
                    int frequencia = Convert.ToInt32(linha.Cells[1].Value);
                    TreeNode no = new TreeNode();
                    no.Tag = new Folha((char)valorCaractere, frequencia);
                    no.Text = $"({frequencia}) {(nomeCaractere.Length == 1 ? $"'{nomeCaractere}'" : nomeCaractere)}";
                    no.ToolTipText = $"Frequência: {frequencia} Caractere: {(nomeCaractere.Length == 1 ? $"'{nomeCaractere}'" : nomeCaractere)}";
                    no.ForeColor = linha.DefaultCellStyle.ForeColor;
                    no.NodeFont = new Font("Consolas", 10, System.Drawing.FontStyle.Bold);
                    trvArvore.Nodes.Add(no);
                }

                if (trvArvore.GetNodeCount(false) > 1)
                {
                    trvArvore.Nodes[0].BackColor = SystemColors.ControlLight;
                    trvArvore.Nodes[1].BackColor = SystemColors.ControlLight;
                }
            }
            else if (trvArvore.GetNodeCount(false) > 1) // Raiz do trvArvore.Nodes contém mais de um TreeNode (ainda há dois ou mais nós a serem combinados)
            {
                // Remove o destaque dos nós reposicionados
                primeiro.BackColor = SystemColors.Window;
                segundo.BackColor = SystemColors.Window;

                // Recupera os primeiros dois nós de trvArvore (os nós com menor peso)
                primeiro = trvArvore.Nodes[0];
                segundo = trvArvore.Nodes[1];

                /*primeiro.ToolTipText = "Lado: 0 " + primeiro.ToolTipText;
                segundo.ToolTipText = "Lado: 1 " + segundo.ToolTipText;
                primeiro.Text = "[0] " + primeiro.Text;
                segundo.Text = "[1] " + segundo.Text;*/
                // Destaca quais nós foram reposicionados no passo anterior
                primeiro.BackColor = SystemColors.ControlLight;
                segundo.BackColor = SystemColors.ControlLight;


                // Remove os últimos dois nós do trvArvore
                trvArvore.Nodes.RemoveAt(0);
                trvArvore.Nodes.RemoveAt(0);

                // Recupera a soma dos pesos dos dois nós
                int pesoDoPrimeiroNo = ((No)primeiro.Tag).Peso;
                int pesoDoSegundoNo = ((No)segundo.Tag).Peso;
                int somaPesosFrequencias = pesoDoPrimeiroNo + pesoDoSegundoNo;

                // Cria um TreeNode como NóPai que tem os dois nós como filhos
                TreeNode treeNodePai = new TreeNode($"({somaPesosFrequencias})");
                treeNodePai.ToolTipText = $"Peso: {somaPesosFrequencias}";
                treeNodePai.Tag = new No(somaPesosFrequencias);
                treeNodePai.Nodes.AddRange(new TreeNode[] { primeiro, segundo });

                trvArvore.Nodes.Add(treeNodePai); // Insere o novo NoPai

                trvArvore.SelectedNode = trvArvore.Nodes[trvArvore.GetNodeCount(false) - 1];
                trvArvore.Sort(); // Ordena em ordem decrescente de Peso


                // Destaca quais nós serão reposicionados no próximo passo
                if (trvArvore.GetNodeCount(false) > 1)
                {
                    trvArvore.Nodes[0].BackColor = Color.LightSeaGreen;
                    trvArvore.Nodes[1].BackColor = Color.LightSeaGreen;
                }
            }
            else // Sobrou só um nó na raiz do trvArvore.Nodes (árvore completa, sem nós soltos)
            {
                primeiro.BackColor = SystemColors.Window;
                segundo.BackColor = SystemColors.Window;

                avancarEstadoDoAlgoritmo();
            }

            trvArvore.ExpandAll();
            trvArvore.Nodes[0].EnsureVisible();
        }



        private void GerarCodigo()
        {
            if (trvArvore.Nodes[0].GetNodeCount(false) == 0) // Não há filhos, só há um nó
            {
                trvArvore.Nodes[0].Text = "0: " + trvArvore.Nodes[0].Text;
                dgvCaracteres.Rows[0].Cells[2].Value = "0";
            }
            else
            {
                CaminharNos("0", trvArvore.Nodes[0].Nodes[0]);
                CaminharNos("1", trvArvore.Nodes[0].Nodes[1]);
            }
            avancarEstadoDoAlgoritmo();
        }

        private void CaminharNos(string caminhoNo, TreeNode No)
        {
            No.Text = caminhoNo[caminhoNo.Length - 1] + ": " + No.Text;
            No.ToolTipText = "Lado: " + caminhoNo[caminhoNo.Length - 1] + " " + No.ToolTipText;

            if (No.Tag is Folha)
            {
                foreach (DataGridViewRow linha in dgvCaracteres.Rows)
                {
                    if ((int)linha.Tag == ((Folha)No.Tag).Caractere)
                    {
                        linha.Cells[2].Value = caminhoNo;
                        break;
                    }
                }
            }
            else // Se No não é Folha, ele é um nó com filhos, e todos nós pais tem 2 e somente 2 filhos
            {
                CaminharNos(caminhoNo + "0", No.Nodes[0]);
                CaminharNos(caminhoNo + "1", No.Nodes[1]);
            }
        }



        private void GerarSaida()
        {
            dgvCaracteres.ClearSelection();

            // Limpa o caminho do trvArvore.Nodes do último passo
            if (trvArvore.Nodes[0].GetNodeCount(false) != 0)
                PintarCaminho(ultimoCaminho, trvArvore.Nodes[0], true); // Para árvores normais
            else
                PintarCaminho("", trvArvore.Nodes[0], true);     // Para árvores com somente um nó

            // Termina o estado atual (EstadoAlgoritmo.LendoEntrada) do algoritmo
            if (caractereAtual == rtbEntrada.Text.Length)
            {
                // Limpa seleção do última caractere
                rtbEntrada.Select(caractereAtual - 1, 1);
                rtbEntrada.SelectionColor = SystemColors.ControlText;
                rtbEntrada.SelectionBackColor = SystemColors.Window;

                // Passa ao algoritmo para o próximo estado
                avancarEstadoDoAlgoritmo();
                timerPasso_Tick(null, null); // Realiza o primeiro passo do ConstruirArvore() (criar e inserir as Folhas "soltas")

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

                // Encontra a linha em dgvCaracteres que corresponde ao caractere selecionado
                char caractere = rtbEntrada.Text[caractereAtual];
                foreach (DataGridViewRow linha in dgvCaracteres.Rows)
                {
                    if (caractere == Convert.ToInt32(linha.Tag))
                    {
                        string codigo = linha.Cells[2].Value.ToString();

                        // Escreve em rtbSaidaBinario o código do caractere
                        rtbSaidaBinario.AppendText(codigo);

                        // Atualiza a contagem de tamanho da saída
                        lblInfoSaida.Text = "Saída: " + Math.Ceiling(rtbSaidaBinario.Text.Length / 8d) + " bytes " + rtbSaidaBinario.Text.Length + " bits";

                        // Atualiza a diferença de tamanho entre a entrada e a saída
                        int porcentagemDiminuicao = (int)((1 - (rtbSaidaBinario.Text.Length / (rtbEntrada.Text.Length * 8d))) * -100);
                        lblInfoDiferenca.Text = "(" + porcentagemDiminuicao + "%)";

                        // Colore o código escrito com a cor do caractere
                        int posicaoInicioDoCodigo = rtbSaidaBinario.Text.Length - codigo.Length;
                        rtbSaidaBinario.Select(posicaoInicioDoCodigo, codigo.Length);
                        rtbSaidaBinario.SelectionColor = linha.DefaultCellStyle.ForeColor;

                        // Destaca o caractere na trvArvore
                        if (trvArvore.Nodes[0].GetNodeCount(false) != 0)
                            PintarCaminho(codigo, trvArvore.Nodes[0], false); // Para árvores normais
                        else
                            PintarCaminho("", trvArvore.Nodes[0], false);     // Para árvores com somente um nó
                        ultimoCaminho = codigo; // Guarda o caminho do trvArvore.Nodes a ser limpado no próximo passo

                        // Destaca a linha do caractere em dgvArvore
                        linha.Selected = true;
                        break;
                    }
                }

                caractereAtual++;
            }
        }

        private void PintarCaminho(string caminhoNo, TreeNode No, bool limpando)
        {
            // Fim do caminho (último dígito)
            if (caminhoNo.Length == 0 || No.GetNodeCount(false) == 0)
            {
                if (!limpando)
                {
                    No.BackColor = Color.LightSeaGreen;
                }
                else
                {
                    No.BackColor = Color.Empty;
                }
                return;
            }

            // Ainda há nós a percorrer
            if (!limpando)
            {
                No.BackColor = SystemColors.ControlLight;
            }
            else
            {
                No.BackColor = Color.Empty;
            }
            PintarCaminho(caminhoNo.Substring(1), No.Nodes[int.Parse(caminhoNo[0].ToString())], limpando);
        }

        private void rtbSaidaBinario_TextChanged(object sender, EventArgs e)
        {
            string binarios = rtbSaidaBinario.Text;

            if (binarios.Length < 8)
            {
                return;
            }

            // Adiciona binários necessários para binarios.Length % 8 = 0
            while (binarios.Length % 8 != 0)
            {
                binarios += "0";
            }

            // Tranforma a string de binários em uma List de bytes
            List<byte> bytes = new List<byte>();
            for (int i = 0; i < binarios.Length; i += 8)
            {
                string byteString = binarios.Substring(i, Math.Max(8, Math.Min(8, binarios.Length - i)));
                bytes.Add(Convert.ToByte(byteString, 2));
            }

            // Permite visualizar os bytes convertidos em caracteres
            rtbSaidaBytes1252.Text = Encoding.GetEncoding(1252).GetString(bytes.ToArray());
            rtbSaidaBytes1252.SelectionStart = rtbSaidaBytes1252.Text.Length;
            rtbSaidaBytes1252.ScrollToCaret();
            rtbSaidaBytesUTF8.Text = Encoding.UTF8.GetString(bytes.ToArray());
            rtbSaidaBytesUTF8.SelectionStart = rtbSaidaBytesUTF8.Text.Length;
            rtbSaidaBytesUTF8.ScrollToCaret();
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

        public class OrganizarNoPorFrequenciaOuPeso : IComparer
        {
            public int Compare(object noX, object noY)
            {
                // Recupera os Pesos dos Nos
                int valorX = ((No)((TreeNode)noX).Tag).Peso;
                int valorY = ((No)((TreeNode)noY).Tag).Peso;

                return valorX.CompareTo(valorY - 1); // -1: Deixa a ordenação estável (impede de trocar de ordem nós com o mesmo peso)
            }
        }

        private void trocarTamanhoFonteSaida()
        {
            // Troca o tamanho da fonte do rtbSaidaBinario baseado no tamanho do texto do rtbEntrada
            int larguraTexto = 1 + TextRenderer.MeasureText(rtbEntrada.Text, new Font("Consolas", 20)).Width;
            if (larguraTexto < rtbEntrada.Width * 2.3)
            {
                rtbSaidaBinario.Font = new Font("Consolas", 16);
            }
            else
            {
                rtbSaidaBinario.Font = new Font("Consolas", 10);
            }
        }

        #endregion
    }
}
