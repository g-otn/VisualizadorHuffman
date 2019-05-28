namespace VisualizadorHuffman
{
    partial class FormVisualizador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node3");
            this.rdbArquivo = new System.Windows.Forms.RadioButton();
            this.rdbTexto = new System.Windows.Forms.RadioButton();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.gpbAndamento = new System.Windows.Forms.GroupBox();
            this.btnProximoPasso = new System.Windows.Forms.Button();
            this.btnPausarContinuar = new System.Windows.Forms.Button();
            this.btnIniciarParar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbSaida = new System.Windows.Forms.RichTextBox();
            this.rtbEntrada = new System.Windows.Forms.RichTextBox();
            this.txt_ArchivePath = new System.Windows.Forms.TextBox();
            this.btn_OpenArchive = new System.Windows.Forms.Button();
            this.gpbArquivo = new System.Windows.Forms.GroupBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.tkbIntervaloPassos = new System.Windows.Forms.TrackBar();
            this.gpbIntervalo = new System.Windows.Forms.GroupBox();
            this.gpbPassos = new System.Windows.Forms.GroupBox();
            this.dgvCaracteres = new System.Windows.Forms.DataGridView();
            this.txt_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_caractere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmb_Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trvArvore = new System.Windows.Forms.TreeView();
            this.gpbOpcoes.SuspendLayout();
            this.gpbAndamento.SuspendLayout();
            this.gpbArquivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbIntervaloPassos)).BeginInit();
            this.gpbIntervalo.SuspendLayout();
            this.gpbPassos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteres)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbArquivo
            // 
            this.rdbArquivo.AutoSize = true;
            this.rdbArquivo.Location = new System.Drawing.Point(35, 22);
            this.rdbArquivo.Name = "rdbArquivo";
            this.rdbArquivo.Size = new System.Drawing.Size(61, 17);
            this.rdbArquivo.TabIndex = 0;
            this.rdbArquivo.TabStop = true;
            this.rdbArquivo.Text = "Arquivo";
            this.rdbArquivo.UseVisualStyleBackColor = true;
            this.rdbArquivo.CheckedChanged += new System.EventHandler(this.opt_Archive_CheckedChanged);
            // 
            // rdbTexto
            // 
            this.rdbTexto.AutoSize = true;
            this.rdbTexto.Location = new System.Drawing.Point(35, 45);
            this.rdbTexto.Name = "rdbTexto";
            this.rdbTexto.Size = new System.Drawing.Size(52, 17);
            this.rdbTexto.TabIndex = 1;
            this.rdbTexto.TabStop = true;
            this.rdbTexto.Text = "Texto";
            this.rdbTexto.UseVisualStyleBackColor = true;
            this.rdbTexto.CheckedChanged += new System.EventHandler(this.opt_Text_CheckedChanged);
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rdbArquivo);
            this.gpbOpcoes.Controls.Add(this.rdbTexto);
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 12);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(132, 78);
            this.gpbOpcoes.TabIndex = 2;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Opções";
            // 
            // gpbAndamento
            // 
            this.gpbAndamento.Controls.Add(this.btnProximoPasso);
            this.gpbAndamento.Controls.Add(this.btnPausarContinuar);
            this.gpbAndamento.Controls.Add(this.btnIniciarParar);
            this.gpbAndamento.Controls.Add(this.label2);
            this.gpbAndamento.Controls.Add(this.label1);
            this.gpbAndamento.Controls.Add(this.rtbSaida);
            this.gpbAndamento.Controls.Add(this.rtbEntrada);
            this.gpbAndamento.Location = new System.Drawing.Point(62, 174);
            this.gpbAndamento.Name = "gpbAndamento";
            this.gpbAndamento.Size = new System.Drawing.Size(654, 132);
            this.gpbAndamento.TabIndex = 3;
            this.gpbAndamento.TabStop = false;
            this.gpbAndamento.Text = "Andamento";
            this.gpbAndamento.Visible = false;
            // 
            // btnProximoPasso
            // 
            this.btnProximoPasso.Location = new System.Drawing.Point(274, 102);
            this.btnProximoPasso.Name = "btnProximoPasso";
            this.btnProximoPasso.Size = new System.Drawing.Size(94, 23);
            this.btnProximoPasso.TabIndex = 10;
            this.btnProximoPasso.Text = "Próximo Passo";
            this.btnProximoPasso.UseVisualStyleBackColor = true;
            // 
            // btnPausarContinuar
            // 
            this.btnPausarContinuar.Location = new System.Drawing.Point(274, 66);
            this.btnPausarContinuar.Name = "btnPausarContinuar";
            this.btnPausarContinuar.Size = new System.Drawing.Size(94, 23);
            this.btnPausarContinuar.TabIndex = 9;
            this.btnPausarContinuar.Text = "Pausar";
            this.btnPausarContinuar.UseVisualStyleBackColor = true;
            this.btnPausarContinuar.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btnIniciarParar
            // 
            this.btnIniciarParar.Location = new System.Drawing.Point(274, 30);
            this.btnIniciarParar.Name = "btnIniciarParar";
            this.btnIniciarParar.Size = new System.Drawing.Size(94, 23);
            this.btnIniciarParar.TabIndex = 8;
            this.btnIniciarParar.Text = "Iniciar";
            this.btnIniciarParar.UseVisualStyleBackColor = true;
            this.btnIniciarParar.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Conteúdo Após Compressão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Conteúdo  Do Arquivo";
            // 
            // rtbSaida
            // 
            this.rtbSaida.Location = new System.Drawing.Point(374, 30);
            this.rtbSaida.Name = "rtbSaida";
            this.rtbSaida.ReadOnly = true;
            this.rtbSaida.ShowSelectionMargin = true;
            this.rtbSaida.Size = new System.Drawing.Size(233, 96);
            this.rtbSaida.TabIndex = 5;
            this.rtbSaida.Text = "";
            // 
            // rtbEntrada
            // 
            this.rtbEntrada.Location = new System.Drawing.Point(35, 30);
            this.rtbEntrada.Name = "rtbEntrada";
            this.rtbEntrada.ShowSelectionMargin = true;
            this.rtbEntrada.Size = new System.Drawing.Size(233, 96);
            this.rtbEntrada.TabIndex = 4;
            this.rtbEntrada.Text = "";
            // 
            // txt_ArchivePath
            // 
            this.txt_ArchivePath.Location = new System.Drawing.Point(12, 40);
            this.txt_ArchivePath.Name = "txt_ArchivePath";
            this.txt_ArchivePath.Size = new System.Drawing.Size(364, 20);
            this.txt_ArchivePath.TabIndex = 4;
            // 
            // btn_OpenArchive
            // 
            this.btn_OpenArchive.Location = new System.Drawing.Point(396, 39);
            this.btn_OpenArchive.Name = "btn_OpenArchive";
            this.btn_OpenArchive.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenArchive.TabIndex = 5;
            this.btn_OpenArchive.Text = "Abrir Arquivo";
            this.btn_OpenArchive.UseVisualStyleBackColor = true;
            this.btn_OpenArchive.Click += new System.EventHandler(this.btn_OpenArchive_Click);
            // 
            // gpbArquivo
            // 
            this.gpbArquivo.Controls.Add(this.btn_OpenArchive);
            this.gpbArquivo.Controls.Add(this.txt_ArchivePath);
            this.gpbArquivo.Location = new System.Drawing.Point(150, 12);
            this.gpbArquivo.Name = "gpbArquivo";
            this.gpbArquivo.Size = new System.Drawing.Size(486, 78);
            this.gpbArquivo.TabIndex = 6;
            this.gpbArquivo.TabStop = false;
            this.gpbArquivo.Text = "Arquivo";
            this.gpbArquivo.Visible = false;
            // 
            // tkbIntervaloPassos
            // 
            this.tkbIntervaloPassos.Location = new System.Drawing.Point(6, 19);
            this.tkbIntervaloPassos.Name = "tkbIntervaloPassos";
            this.tkbIntervaloPassos.Size = new System.Drawing.Size(225, 45);
            this.tkbIntervaloPassos.TabIndex = 7;
            this.tkbIntervaloPassos.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // gpbIntervalo
            // 
            this.gpbIntervalo.Controls.Add(this.tkbIntervaloPassos);
            this.gpbIntervalo.Location = new System.Drawing.Point(286, 312);
            this.gpbIntervalo.Name = "gpbIntervalo";
            this.gpbIntervalo.Size = new System.Drawing.Size(237, 72);
            this.gpbIntervalo.TabIndex = 8;
            this.gpbIntervalo.TabStop = false;
            this.gpbIntervalo.Text = "Inervalo Entre  Passos";
            // 
            // gpbPassos
            // 
            this.gpbPassos.Controls.Add(this.dgvCaracteres);
            this.gpbPassos.Controls.Add(this.trvArvore);
            this.gpbPassos.Location = new System.Drawing.Point(62, 390);
            this.gpbPassos.Name = "gpbPassos";
            this.gpbPassos.Size = new System.Drawing.Size(654, 153);
            this.gpbPassos.TabIndex = 9;
            this.gpbPassos.TabStop = false;
            this.gpbPassos.Text = "Passos Da Compressão";
            // 
            // dgvCaracteres
            // 
            this.dgvCaracteres.AllowUserToDeleteRows = false;
            this.dgvCaracteres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_code,
            this.txt_caractere,
            this.nmb_Frequency});
            this.dgvCaracteres.Location = new System.Drawing.Point(297, 19);
            this.dgvCaracteres.Name = "dgvCaracteres";
            this.dgvCaracteres.ReadOnly = true;
            this.dgvCaracteres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCaracteres.Size = new System.Drawing.Size(342, 128);
            this.dgvCaracteres.TabIndex = 10;
            // 
            // txt_code
            // 
            this.txt_code.HeaderText = "Código";
            this.txt_code.Name = "txt_code";
            this.txt_code.ReadOnly = true;
            // 
            // txt_caractere
            // 
            this.txt_caractere.HeaderText = "Caractere";
            this.txt_caractere.Name = "txt_caractere";
            this.txt_caractere.ReadOnly = true;
            // 
            // nmb_Frequency
            // 
            this.nmb_Frequency.HeaderText = "Frequência";
            this.nmb_Frequency.Name = "nmb_Frequency";
            this.nmb_Frequency.ReadOnly = true;
            // 
            // trvArvore
            // 
            this.trvArvore.Location = new System.Drawing.Point(35, 19);
            this.trvArvore.Name = "trvArvore";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Node1";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Node2";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Node3";
            this.trvArvore.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.trvArvore.Size = new System.Drawing.Size(233, 128);
            this.trvArvore.TabIndex = 0;
            // 
            // FormVisualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.gpbPassos);
            this.Controls.Add(this.gpbIntervalo);
            this.Controls.Add(this.gpbArquivo);
            this.Controls.Add(this.gpbAndamento);
            this.Controls.Add(this.gpbOpcoes);
            this.Name = "FormVisualizador";
            this.Text = "Visualizador Huffman";
            this.Load += new System.EventHandler(this.FormVisualizer_Load);
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.gpbAndamento.ResumeLayout(false);
            this.gpbAndamento.PerformLayout();
            this.gpbArquivo.ResumeLayout(false);
            this.gpbArquivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbIntervaloPassos)).EndInit();
            this.gpbIntervalo.ResumeLayout(false);
            this.gpbIntervalo.PerformLayout();
            this.gpbPassos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbArquivo;
        private System.Windows.Forms.RadioButton rdbTexto;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.GroupBox gpbAndamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbSaida;
        private System.Windows.Forms.RichTextBox rtbEntrada;
        private System.Windows.Forms.TextBox txt_ArchivePath;
        private System.Windows.Forms.Button btn_OpenArchive;
        private System.Windows.Forms.GroupBox gpbArquivo;
        private System.Windows.Forms.Button btnProximoPasso;
        private System.Windows.Forms.Button btnPausarContinuar;
        private System.Windows.Forms.Button btnIniciarParar;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TrackBar tkbIntervaloPassos;
        private System.Windows.Forms.GroupBox gpbIntervalo;
        private System.Windows.Forms.GroupBox gpbPassos;
        private System.Windows.Forms.TreeView trvArvore;
        private System.Windows.Forms.DataGridView dgvCaracteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_caractere;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmb_Frequency;
    }
}