using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void btn_OpenArchive_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        private void btnIniciarParar_Click(object sender, EventArgs e)
        {
            if (btnIniciarParar.Text == "Iniciar")
            {
                // Iniciar
                btnIniciarParar.Text = "Parar";
                Comprimir();
            }
            else
            {
                // Parar
                btnIniciarParar.Text = "Iniciar";
                // limpar timer
            }
        }

        private void btnPausarContinuar_Click(object sender, EventArgs e)
        {
            if (btnPausarContinuar.Text == "Pausar")
            {
                btnPausarContinuar.Text = "Continuar";
            }
            else
            {
                btnPausarContinuar.Text = "Pausar";
            }
            
        }

        private void RdbTexto_CheckedChanged(object sender, EventArgs e)
        {
            txtCaminhoArquivo.Enabled = false;
            btnAbrirArquivo.Enabled = true;
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

        private void Comprimir()
        {
            // Declarar variáveis

            // Limpar controles


            // Preparar Controles
            txtEntrada.ReadOnly = true; // Evita edição durante a seleção pelo programa

            // Iniciar compressão
                // set timeout do Timer
        }
    }
}
