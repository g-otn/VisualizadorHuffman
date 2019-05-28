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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node3");
            this.rdbArquivo = new System.Windows.Forms.RadioButton();
            this.rdbTexto = new System.Windows.Forms.RadioButton();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.grp_Progress = new System.Windows.Forms.GroupBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txt_ArchivePath = new System.Windows.Forms.TextBox();
            this.btn_OpenArchive = new System.Windows.Forms.Button();
            this.grp_Archive = new System.Windows.Forms.GroupBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.trck_Interval = new System.Windows.Forms.TrackBar();
            this.grp_Interval = new System.Windows.Forms.GroupBox();
            this.grp_Steps = new System.Windows.Forms.GroupBox();
            this.dtg_Steps = new System.Windows.Forms.DataGridView();
            this.txt_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_caractere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmb_Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.gpbOpcoes.SuspendLayout();
            this.grp_Progress.SuspendLayout();
            this.grp_Archive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trck_Interval)).BeginInit();
            this.grp_Interval.SuspendLayout();
            this.grp_Steps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Steps)).BeginInit();
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
            // grp_Progress
            // 
            this.grp_Progress.Controls.Add(this.btn_next);
            this.grp_Progress.Controls.Add(this.btn_pause);
            this.grp_Progress.Controls.Add(this.btn_start);
            this.grp_Progress.Controls.Add(this.label2);
            this.grp_Progress.Controls.Add(this.label1);
            this.grp_Progress.Controls.Add(this.richTextBox2);
            this.grp_Progress.Controls.Add(this.richTextBox1);
            this.grp_Progress.Location = new System.Drawing.Point(62, 174);
            this.grp_Progress.Name = "grp_Progress";
            this.grp_Progress.Size = new System.Drawing.Size(654, 132);
            this.grp_Progress.TabIndex = 3;
            this.grp_Progress.TabStop = false;
            this.grp_Progress.Text = "Andamento";
            this.grp_Progress.Visible = false;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(274, 102);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(94, 23);
            this.btn_next.TabIndex = 10;
            this.btn_next.Text = "Próximo Passo";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(274, 66);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(94, 23);
            this.btn_pause.TabIndex = 9;
            this.btn_pause.Text = "Pausar";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(274, 30);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(94, 23);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Iniciar";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
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
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(374, 30);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ShowSelectionMargin = true;
            this.richTextBox2.Size = new System.Drawing.Size(233, 96);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(233, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
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
            // grp_Archive
            // 
            this.grp_Archive.Controls.Add(this.btn_OpenArchive);
            this.grp_Archive.Controls.Add(this.txt_ArchivePath);
            this.grp_Archive.Location = new System.Drawing.Point(150, 12);
            this.grp_Archive.Name = "grp_Archive";
            this.grp_Archive.Size = new System.Drawing.Size(486, 78);
            this.grp_Archive.TabIndex = 6;
            this.grp_Archive.TabStop = false;
            this.grp_Archive.Text = "Arquivo";
            this.grp_Archive.Visible = false;
            // 
            // trck_Interval
            // 
            this.trck_Interval.Location = new System.Drawing.Point(6, 19);
            this.trck_Interval.Name = "trck_Interval";
            this.trck_Interval.Size = new System.Drawing.Size(225, 45);
            this.trck_Interval.TabIndex = 7;
            this.trck_Interval.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // grp_Interval
            // 
            this.grp_Interval.Controls.Add(this.trck_Interval);
            this.grp_Interval.Location = new System.Drawing.Point(286, 312);
            this.grp_Interval.Name = "grp_Interval";
            this.grp_Interval.Size = new System.Drawing.Size(237, 72);
            this.grp_Interval.TabIndex = 8;
            this.grp_Interval.TabStop = false;
            this.grp_Interval.Text = "Inervalo Entre  Passos";
            // 
            // grp_Steps
            // 
            this.grp_Steps.Controls.Add(this.dtg_Steps);
            this.grp_Steps.Controls.Add(this.treeView1);
            this.grp_Steps.Location = new System.Drawing.Point(62, 390);
            this.grp_Steps.Name = "grp_Steps";
            this.grp_Steps.Size = new System.Drawing.Size(654, 153);
            this.grp_Steps.TabIndex = 9;
            this.grp_Steps.TabStop = false;
            this.grp_Steps.Text = "Passos Da Compressão";
            // 
            // dtg_Steps
            // 
            this.dtg_Steps.AllowUserToDeleteRows = false;
            this.dtg_Steps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Steps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_code,
            this.txt_caractere,
            this.nmb_Frequency});
            this.dtg_Steps.Location = new System.Drawing.Point(297, 19);
            this.dtg_Steps.Name = "dtg_Steps";
            this.dtg_Steps.ReadOnly = true;
            this.dtg_Steps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_Steps.Size = new System.Drawing.Size(342, 128);
            this.dtg_Steps.TabIndex = 10;
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
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(35, 19);
            this.treeView1.Name = "treeView1";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Node0";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Node1";
            treeNode7.Name = "Node2";
            treeNode7.Text = "Node2";
            treeNode8.Name = "Node3";
            treeNode8.Text = "Node3";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(233, 128);
            this.treeView1.TabIndex = 0;
            // 
            // FormVisualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.grp_Steps);
            this.Controls.Add(this.grp_Interval);
            this.Controls.Add(this.grp_Archive);
            this.Controls.Add(this.grp_Progress);
            this.Controls.Add(this.gpbOpcoes);
            this.Name = "FormVisualizador";
            this.Text = "Visualizador Huffman";
            this.Load += new System.EventHandler(this.FormVisualizer_Load);
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.grp_Progress.ResumeLayout(false);
            this.grp_Progress.PerformLayout();
            this.grp_Archive.ResumeLayout(false);
            this.grp_Archive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trck_Interval)).EndInit();
            this.grp_Interval.ResumeLayout(false);
            this.grp_Interval.PerformLayout();
            this.grp_Steps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Steps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbArquivo;
        private System.Windows.Forms.RadioButton rdbTexto;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.GroupBox grp_Progress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txt_ArchivePath;
        private System.Windows.Forms.Button btn_OpenArchive;
        private System.Windows.Forms.GroupBox grp_Archive;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TrackBar trck_Interval;
        private System.Windows.Forms.GroupBox grp_Interval;
        private System.Windows.Forms.GroupBox grp_Steps;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dtg_Steps;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_caractere;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmb_Frequency;
    }
}