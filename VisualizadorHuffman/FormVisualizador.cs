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
        private int indiceSelecao = 0;


        public FormVisualizador()
        {
            InitializeComponent();
            this.ActiveControl = rtbEntrada;
            timerPasso.Start();
        }



        #region Eventos dos controles de entrada

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            if (ofdArquivoEntrada.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoArquivo.ForeColor = SystemColors.ControlText;
                txtCaminhoArquivo.Text = ofdArquivoEntrada.FileName;
                rtbEntrada.ForeColor = SystemColors.ControlText;
                rtbEntrada.Text = File.ReadAllText(ofdArquivoEntrada.FileName);
                lblInfoEntrada.Text = $"Entrada: {rtbEntrada.Text.Length} bytes, {rtbEntrada.Text.Length * 8} bits";
            }
        }

        private void txtCaminhoArquivo_Leave(object sender, EventArgs e)
        {
            if (txtCaminhoArquivo.Text != ofdArquivoEntrada.FileName)
            {
                try
                {
                    rtbEntrada.Text = File.ReadAllText(txtCaminhoArquivo.Text);
                    txtCaminhoArquivo.ForeColor = SystemColors.ControlText;
                    lblInfoEntrada.Text = $"Entrada: {rtbEntrada.Text.Length} bytes, {rtbEntrada.Text.Length * 8} bits";
                }
                catch
                {
                    txtCaminhoArquivo.ForeColor = Color.Red;
                }
            }
        }

        #endregion



        #region Eventos dos controles de controle

        private void btnIniciarParar_Click(object sender, EventArgs e)
        {
            if (btnIniciarParar.Text == "Iniciar") // Iniciar
            {
                // Iniciar
                if (rtbEntrada.ForeColor == SystemColors.GrayText)
                {
                    MessageBox.Show("Digite algo na caixa de texto de entrada!");
                    return;
                }

                // Reiniciar controles
                btnIniciarParar.Text = "Parar";
                btnPausarContinuar.Text = "Pausar";
                tkbIntervaloPassos.Value = 750;

                trvArvore.Nodes.Clear();
                dgvCaracteres.Rows.Clear();

                // Preparar controles
                btnAbrirArquivo.Enabled = false;
                txtCaminhoArquivo.ReadOnly = true;
                rtbEntrada.ReadOnly = true;
                rtbEntrada.SelectionStart = 0;
                rtbEntrada.SelectionLength = 1;


                Comprimir();
            }
            else                                    // Parar
            {
                indiceSelecao = 0;

                // Reiniciar controles
                timerPasso.Tick -= LerEntrada;
                //timerPasso.Tick -= ;
                //timerPasso.Tick -= ;
                timerPasso.Stop();

                btnAbrirArquivo.Enabled = true;
                txtCaminhoArquivo.ReadOnly = false;
                rtbEntrada.ReadOnly = false;
                rtbEntrada.SelectAll();
                rtbEntrada.SelectionBackColor = SystemColors.Window;

                btnIniciarParar.Text = "Iniciar";
                btnPausarContinuar.Text = "Pausar";
                tkbIntervaloPassos.Value = 1000;
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

            timerPasso.Stop();
        }

        private void rtbEntrada_Enter(object sender, EventArgs e)
        {
            if (rtbEntrada.ForeColor == SystemColors.GrayText && rtbEntrada.Text == "Digite alguma coisa...")
            {
                rtbEntrada.Clear();
                rtbEntrada.ForeColor = SystemColors.WindowText;
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
            timerPasso.Interval = 1 + tkbIntervaloPassos.Maximum - tkbIntervaloPassos.Value;
        }

        #endregion



        #region Eventos dos controles dos passos



        #endregion



        #region Métodos do algoritmo

        private void Comprimir()
        {
            // Timer
            timerPasso.Tick += new System.EventHandler(LerEntrada);
            timerPasso.Start();

            //timerPasso.Tick -= evento1;
            //timerPasso.Tick += new System.EventHandler(evento2);


            //timerPasso.Stop();
        }

        private void LerEntrada(object sender, EventArgs e)
        {
            try
            {
                LockWindowUpdate(rtbEntrada.Handle); // Impede flickering no rtbEntrada

                // Remove o destaque do caractere anterior
                if (indiceSelecao != 0)
                {
                    rtbEntrada.Select(indiceSelecao - 1, 1);
                    rtbEntrada.SelectionColor = SystemColors.ControlText;
                    rtbEntrada.SelectionBackColor = SystemColors.Window;
                }

                // Destaca o caractere atual no rtbEntrada
                rtbEntrada.Select(indiceSelecao, 1);
                rtbEntrada.SelectionColor = SystemColors.HighlightText;
                rtbEntrada.SelectionBackColor = Color.LightSeaGreen;

                rtbEntrada.ScrollToCaret();
            } finally
            {
                LockWindowUpdate(IntPtr.Zero);

                indiceSelecao++;
                lblInfoDiferenca.Text = rtbEntrada.SelectionStart.ToString();

                // Cria ou modifica a linha do caractere no dgvCaracteres


                // Cria ou modifica a representação da folha no trvArvore



                // quando ler tudo remover por aqui esse evento
                if (indiceSelecao == rtbEntrada.Text.Length)
                {
                    timerPasso.Tick -= LerEntrada;
                    timerPasso.Stop();

                    // Limpa seleção do última caractere
                    rtbEntrada.Select(indiceSelecao - 1, 1);
                    rtbEntrada.SelectionColor = SystemColors.ControlText;
                    rtbEntrada.SelectionBackColor = SystemColors.Window;
                }
            }
        }

        #endregion



        #region Outros Métodos

        private void lnkGitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/g-otn/VisualizadorHuffman");
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(IntPtr windowLock);

        #endregion
    }
}
