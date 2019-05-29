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
        public FormVisualizador()
        {
            InitializeComponent();
            this.ActiveControl = txtEntrada;
            timerPasso.Start();
        }



        #region Eventos dos controles de entrada

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            if (ofdArquivoEntrada.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoArquivo.ForeColor = SystemColors.ControlText;
                txtCaminhoArquivo.Text = ofdArquivoEntrada.FileName;
                txtEntrada.ForeColor = SystemColors.ControlText;
                txtEntrada.Text = File.ReadAllText(ofdArquivoEntrada.FileName, Encoding.GetEncoding(1252));
                lblInfoEntrada.Text = $"Entrada: {txtEntrada.Text.Length} bytes, {txtEntrada.Text.Length * 8} bits";
            }
        }

        private void txtCaminhoArquivo_Leave(object sender, EventArgs e)
        {
            if (txtCaminhoArquivo.Text != ofdArquivoEntrada.FileName)
            {
                try
                {
                    txtEntrada.Text = File.ReadAllText(txtCaminhoArquivo.Text, Encoding.GetEncoding(1252));
                    txtCaminhoArquivo.ForeColor = SystemColors.ControlText;
                    lblInfoEntrada.Text = $"Entrada: {txtEntrada.Text.Length} bytes, {txtEntrada.Text.Length * 8} bits";
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
            MessageBox.Show("aa");
            if (btnIniciarParar.Text == "Iniciar") // Iniciar
            {
                // Iniciar
                if (txtEntrada.ForeColor == SystemColors.GrayText)
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
                txtEntrada.ReadOnly = true;
                txtEntrada.SelectionStart = 0;
                txtEntrada.SelectionLength = 1;


                Comprimir();
            }
            else                                    // Parar
            {
                // Reiniciar controles
                timerPasso.Stop();

                btnAbrirArquivo.Enabled = true;
                txtCaminhoArquivo.ReadOnly = false;
                txtEntrada.ReadOnly = false;

                btnIniciarParar.Text = "Iniciar";
                btnPausarContinuar.Text = "Pausar";
                tkbIntervaloPassos.Value = 1000;

                // limpar timer
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

        private void TxtEntrada_Enter(object sender, EventArgs e)
        {
            if (txtEntrada.ForeColor == SystemColors.GrayText && txtEntrada.Text == "Digite alguma coisa...")
            {
                txtEntrada.Clear();
                txtEntrada.ForeColor = SystemColors.WindowText;
            }
        }

        private void TxtEntrada_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEntrada.Text))
            {
                txtEntrada.Text = "Digite alguma coisa...";
                txtEntrada.ForeColor = SystemColors.GrayText;
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
            timerPasso.Tick += new System.EventHandler(lerEntrada);
            timerPasso.Start();

            //timerPasso.Tick -= evento1;
            //timerPasso.Tick += new System.EventHandler(evento2);


            //timerPasso.Stop();
        }

        private void lerEntrada(object sender, EventArgs e)
        {
            // Destaca o caractere atual no txtEntrada
            txtEntrada.Focus();
            txtEntrada.SelectionStart++;// txtEntrada.SelectionStart = variavel da posição;
            txtEntrada.ScrollToCaret();
            lblInfoDiferenca.Text = txtEntrada.SelectionStart.ToString();

            // Cria ou modifica a linha do caractere no dgvCaracteres


            // Cria ou modifica a representação da folha no trvArvore


            // quando ler tudo remover por aqui esse evento
        }

        #endregion


        #region Outros Métodos

        private void lnkGitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/g-otn/VisualizadorHuffman");
        }

        #endregion
    }
}
