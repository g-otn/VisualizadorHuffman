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
        }

        private void FormVisualizer_Load(object sender, EventArgs e)
        {
           
        }

        private void opt_Archive_CheckedChanged(object sender, EventArgs e)
        {
            gpbArquivo.Visible = true;
            gpbAndamento.Visible = true;
        }

        private void opt_Text_CheckedChanged(object sender, EventArgs e)
        {
            gpbAndamento.Visible = true;
            gpbArquivo.Visible = false;

        }

        private void btn_OpenArchive_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btnIniciarParar.Text == "Iniciar")
            {
                btnIniciarParar.Text = "Parar";
            }
            else
            {
                btnIniciarParar.Text = "Iniciar";
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
