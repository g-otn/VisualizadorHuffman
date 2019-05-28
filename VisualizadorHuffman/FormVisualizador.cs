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
            grp_Archive.Visible = true;
            grp_Progress.Visible = true;
        }

        private void opt_Text_CheckedChanged(object sender, EventArgs e)
        {
            grp_Progress.Visible = true;
            grp_Archive.Visible = false;

        }

        private void btn_OpenArchive_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_start.Text == "Iniciar")
            {
                btn_start.Text = "Parar";
            }
            else
            {
                btn_start.Text = "Iniciar";
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (btn_pause.Text == "Pausar")
            {
                btn_pause.Text = "Continuar";
            }
            else
            {
                btn_pause.Text = "Pausar";
            }
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
