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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nó0");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node3");
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.txtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.gpbControle = new System.Windows.Forms.GroupBox();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.tkbIntervaloPassos = new System.Windows.Forms.TrackBar();
            this.btnProximoPasso = new System.Windows.Forms.Button();
            this.btnPausarContinuar = new System.Windows.Forms.Button();
            this.btnIniciarParar = new System.Windows.Forms.Button();
            this.lblBinarioGerado = new System.Windows.Forms.Label();
            this.rtbSaidaBinario = new System.Windows.Forms.RichTextBox();
            this.ofdArquivoEntrada = new System.Windows.Forms.OpenFileDialog();
            this.gpbPassos = new System.Windows.Forms.GroupBox();
            this.dgvCaracteres = new System.Windows.Forms.DataGridView();
            this.txtCaractere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmb_Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trvArvore = new System.Windows.Forms.TreeView();
            this.gpbSaida = new System.Windows.Forms.GroupBox();
            this.lblBinarioParaByte = new System.Windows.Forms.Label();
            this.rtbSaidaBytes = new System.Windows.Forms.RichTextBox();
            this.panInformacoes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfoReducao = new System.Windows.Forms.Label();
            this.lblInfoEntrada = new System.Windows.Forms.Label();
            this.gpbOpcoes.SuspendLayout();
            this.gpbControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbIntervaloPassos)).BeginInit();
            this.gpbPassos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteres)).BeginInit();
            this.gpbSaida.SuspendLayout();
            this.panInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.txtEntrada);
            this.gpbOpcoes.Controls.Add(this.btnAbrirArquivo);
            this.gpbOpcoes.Controls.Add(this.txtCaminhoArquivo);
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 12);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Padding = new System.Windows.Forms.Padding(6);
            this.gpbOpcoes.Size = new System.Drawing.Size(433, 150);
            this.gpbOpcoes.TabIndex = 2;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Entrada";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntrada.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtEntrada.Location = new System.Drawing.Point(9, 51);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntrada.Size = new System.Drawing.Size(415, 90);
            this.txtEntrada.TabIndex = 6;
            this.txtEntrada.Text = "Digite alguma coisa...";
            this.txtEntrada.Enter += new System.EventHandler(this.TxtEntrada_Enter);
            this.txtEntrada.Leave += new System.EventHandler(this.TxtEntrada_Leave);
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Location = new System.Drawing.Point(9, 22);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(113, 23);
            this.btnAbrirArquivo.TabIndex = 5;
            this.btnAbrirArquivo.Text = "Abrir Arquivo";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(128, 24);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(296, 20);
            this.txtCaminhoArquivo.TabIndex = 4;
            // 
            // gpbControle
            // 
            this.gpbControle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbControle.Controls.Add(this.lblVelocidade);
            this.gpbControle.Controls.Add(this.tkbIntervaloPassos);
            this.gpbControle.Controls.Add(this.btnProximoPasso);
            this.gpbControle.Controls.Add(this.btnPausarContinuar);
            this.gpbControle.Controls.Add(this.btnIniciarParar);
            this.gpbControle.Location = new System.Drawing.Point(451, 12);
            this.gpbControle.Name = "gpbControle";
            this.gpbControle.Size = new System.Drawing.Size(539, 57);
            this.gpbControle.TabIndex = 3;
            this.gpbControle.TabStop = false;
            this.gpbControle.Text = "Controle";
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.AutoSize = true;
            this.lblVelocidade.Location = new System.Drawing.Point(318, 24);
            this.lblVelocidade.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(60, 13);
            this.lblVelocidade.TabIndex = 8;
            this.lblVelocidade.Text = "Velocidade";
            // 
            // tkbIntervaloPassos
            // 
            this.tkbIntervaloPassos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkbIntervaloPassos.Location = new System.Drawing.Point(384, 19);
            this.tkbIntervaloPassos.Maximum = 3000;
            this.tkbIntervaloPassos.Name = "tkbIntervaloPassos";
            this.tkbIntervaloPassos.Size = new System.Drawing.Size(149, 45);
            this.tkbIntervaloPassos.TabIndex = 11;
            this.tkbIntervaloPassos.TickFrequency = 300;
            this.tkbIntervaloPassos.Value = 1000;
            // 
            // btnProximoPasso
            // 
            this.btnProximoPasso.Location = new System.Drawing.Point(209, 19);
            this.btnProximoPasso.Name = "btnProximoPasso";
            this.btnProximoPasso.Size = new System.Drawing.Size(94, 23);
            this.btnProximoPasso.TabIndex = 10;
            this.btnProximoPasso.Text = "Próximo Passo";
            this.btnProximoPasso.UseVisualStyleBackColor = true;
            // 
            // btnPausarContinuar
            // 
            this.btnPausarContinuar.Location = new System.Drawing.Point(109, 19);
            this.btnPausarContinuar.Name = "btnPausarContinuar";
            this.btnPausarContinuar.Size = new System.Drawing.Size(94, 23);
            this.btnPausarContinuar.TabIndex = 9;
            this.btnPausarContinuar.Text = "Pausar";
            this.btnPausarContinuar.UseVisualStyleBackColor = true;
            this.btnPausarContinuar.Click += new System.EventHandler(this.btnPausarContinuar_Click);
            // 
            // btnIniciarParar
            // 
            this.btnIniciarParar.Location = new System.Drawing.Point(9, 19);
            this.btnIniciarParar.Name = "btnIniciarParar";
            this.btnIniciarParar.Size = new System.Drawing.Size(94, 23);
            this.btnIniciarParar.TabIndex = 8;
            this.btnIniciarParar.Text = "Iniciar";
            this.btnIniciarParar.UseVisualStyleBackColor = true;
            this.btnIniciarParar.Click += new System.EventHandler(this.btnIniciarParar_Click);
            // 
            // lblBinarioGerado
            // 
            this.lblBinarioGerado.AutoSize = true;
            this.lblBinarioGerado.Location = new System.Drawing.Point(9, 19);
            this.lblBinarioGerado.Name = "lblBinarioGerado";
            this.lblBinarioGerado.Size = new System.Drawing.Size(77, 13);
            this.lblBinarioGerado.TabIndex = 7;
            this.lblBinarioGerado.Text = "Binário Gerado";
            // 
            // rtbSaidaBinario
            // 
            this.rtbSaidaBinario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSaidaBinario.BackColor = System.Drawing.SystemColors.Window;
            this.rtbSaidaBinario.Location = new System.Drawing.Point(9, 35);
            this.rtbSaidaBinario.Name = "rtbSaidaBinario";
            this.rtbSaidaBinario.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSaidaBinario.ShowSelectionMargin = true;
            this.rtbSaidaBinario.Size = new System.Drawing.Size(415, 114);
            this.rtbSaidaBinario.TabIndex = 5;
            this.rtbSaidaBinario.TabStop = false;
            this.rtbSaidaBinario.Text = "";
            // 
            // ofdArquivoEntrada
            // 
            this.ofdArquivoEntrada.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            // 
            // gpbPassos
            // 
            this.gpbPassos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbPassos.Controls.Add(this.dgvCaracteres);
            this.gpbPassos.Controls.Add(this.trvArvore);
            this.gpbPassos.Location = new System.Drawing.Point(451, 75);
            this.gpbPassos.Name = "gpbPassos";
            this.gpbPassos.Padding = new System.Windows.Forms.Padding(6);
            this.gpbPassos.Size = new System.Drawing.Size(539, 334);
            this.gpbPassos.TabIndex = 9;
            this.gpbPassos.TabStop = false;
            this.gpbPassos.Text = "Passos Da Compressão";
            // 
            // dgvCaracteres
            // 
            this.dgvCaracteres.AllowUserToAddRows = false;
            this.dgvCaracteres.AllowUserToDeleteRows = false;
            this.dgvCaracteres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaracteres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCaracteres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCaractere,
            this.nmb_Frequency,
            this.txt_code});
            this.dgvCaracteres.Location = new System.Drawing.Point(302, 22);
            this.dgvCaracteres.MultiSelect = false;
            this.dgvCaracteres.Name = "dgvCaracteres";
            this.dgvCaracteres.ReadOnly = true;
            this.dgvCaracteres.RowHeadersVisible = false;
            this.dgvCaracteres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvCaracteres.ShowCellErrors = false;
            this.dgvCaracteres.ShowCellToolTips = false;
            this.dgvCaracteres.ShowEditingIcon = false;
            this.dgvCaracteres.ShowRowErrors = false;
            this.dgvCaracteres.Size = new System.Drawing.Size(228, 303);
            this.dgvCaracteres.TabIndex = 10;
            // 
            // txtCaractere
            // 
            this.txtCaractere.HeaderText = "Caractere";
            this.txtCaractere.Name = "txtCaractere";
            this.txtCaractere.ReadOnly = true;
            this.txtCaractere.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtCaractere.ToolTipText = "Os caracteres distintos presentes na entrada";
            this.txtCaractere.Width = 60;
            // 
            // nmb_Frequency
            // 
            this.nmb_Frequency.HeaderText = "Frequência";
            this.nmb_Frequency.Name = "nmb_Frequency";
            this.nmb_Frequency.ReadOnly = true;
            this.nmb_Frequency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nmb_Frequency.Width = 65;
            // 
            // txt_code
            // 
            this.txt_code.HeaderText = "Código";
            this.txt_code.Name = "txt_code";
            this.txt_code.ReadOnly = true;
            this.txt_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // trvArvore
            // 
            this.trvArvore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trvArvore.Indent = 40;
            this.trvArvore.Location = new System.Drawing.Point(9, 22);
            this.trvArvore.Name = "trvArvore";
            treeNode11.Name = "Nó0";
            treeNode11.Text = "Nó0";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Node0";
            treeNode13.Name = "Node1";
            treeNode13.Text = "Node1";
            treeNode14.Name = "Node2";
            treeNode14.Text = "Node2";
            treeNode15.Name = "Node3";
            treeNode15.Text = "Node3";
            this.trvArvore.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            this.trvArvore.Size = new System.Drawing.Size(287, 303);
            this.trvArvore.TabIndex = 0;
            // 
            // gpbSaida
            // 
            this.gpbSaida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbSaida.Controls.Add(this.lblBinarioParaByte);
            this.gpbSaida.Controls.Add(this.rtbSaidaBytes);
            this.gpbSaida.Controls.Add(this.panInformacoes);
            this.gpbSaida.Controls.Add(this.rtbSaidaBinario);
            this.gpbSaida.Controls.Add(this.lblBinarioGerado);
            this.gpbSaida.Location = new System.Drawing.Point(12, 168);
            this.gpbSaida.MinimumSize = new System.Drawing.Size(0, 150);
            this.gpbSaida.Name = "gpbSaida";
            this.gpbSaida.Padding = new System.Windows.Forms.Padding(6);
            this.gpbSaida.Size = new System.Drawing.Size(433, 241);
            this.gpbSaida.TabIndex = 10;
            this.gpbSaida.TabStop = false;
            this.gpbSaida.Text = "Saída";
            // 
            // lblBinarioParaByte
            // 
            this.lblBinarioParaByte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBinarioParaByte.AutoSize = true;
            this.lblBinarioParaByte.Location = new System.Drawing.Point(9, 152);
            this.lblBinarioParaByte.Name = "lblBinarioParaByte";
            this.lblBinarioParaByte.Size = new System.Drawing.Size(85, 13);
            this.lblBinarioParaByte.TabIndex = 8;
            this.lblBinarioParaByte.Text = "Binário em Bytes";
            // 
            // rtbSaidaBytes
            // 
            this.rtbSaidaBytes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSaidaBytes.BackColor = System.Drawing.SystemColors.Window;
            this.rtbSaidaBytes.Location = new System.Drawing.Point(9, 168);
            this.rtbSaidaBytes.Name = "rtbSaidaBytes";
            this.rtbSaidaBytes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSaidaBytes.ShowSelectionMargin = true;
            this.rtbSaidaBytes.Size = new System.Drawing.Size(244, 64);
            this.rtbSaidaBytes.TabIndex = 9;
            this.rtbSaidaBytes.TabStop = false;
            this.rtbSaidaBytes.Text = "";
            // 
            // panInformacoes
            // 
            this.panInformacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panInformacoes.Controls.Add(this.label1);
            this.panInformacoes.Controls.Add(this.lblInfoReducao);
            this.panInformacoes.Controls.Add(this.lblInfoEntrada);
            this.panInformacoes.Location = new System.Drawing.Point(260, 168);
            this.panInformacoes.Name = "panInformacoes";
            this.panInformacoes.Size = new System.Drawing.Size(164, 64);
            this.panInformacoes.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saída:";
            // 
            // lblInfoReducao
            // 
            this.lblInfoReducao.Location = new System.Drawing.Point(3, 47);
            this.lblInfoReducao.Name = "lblInfoReducao";
            this.lblInfoReducao.Size = new System.Drawing.Size(158, 13);
            this.lblInfoReducao.TabIndex = 1;
            this.lblInfoReducao.Text = "Redução:";
            // 
            // lblInfoEntrada
            // 
            this.lblInfoEntrada.Location = new System.Drawing.Point(3, 3);
            this.lblInfoEntrada.Name = "lblInfoEntrada";
            this.lblInfoEntrada.Size = new System.Drawing.Size(157, 13);
            this.lblInfoEntrada.TabIndex = 0;
            this.lblInfoEntrada.Text = "Entrada:";
            // 
            // FormVisualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 421);
            this.Controls.Add(this.gpbSaida);
            this.Controls.Add(this.gpbPassos);
            this.Controls.Add(this.gpbControle);
            this.Controls.Add(this.gpbOpcoes);
            this.Name = "FormVisualizador";
            this.Text = "Visualizador Huffman";
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.gpbControle.ResumeLayout(false);
            this.gpbControle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbIntervaloPassos)).EndInit();
            this.gpbPassos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteres)).EndInit();
            this.gpbSaida.ResumeLayout(false);
            this.gpbSaida.PerformLayout();
            this.panInformacoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.GroupBox gpbControle;
        private System.Windows.Forms.Label lblBinarioGerado;
        private System.Windows.Forms.RichTextBox rtbSaidaBinario;
        private System.Windows.Forms.TextBox txtCaminhoArquivo;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.Button btnProximoPasso;
        private System.Windows.Forms.Button btnPausarContinuar;
        private System.Windows.Forms.Button btnIniciarParar;
        private System.Windows.Forms.OpenFileDialog ofdArquivoEntrada;
        private System.Windows.Forms.GroupBox gpbPassos;
        private System.Windows.Forms.TreeView trvArvore;
        private System.Windows.Forms.DataGridView dgvCaracteres;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TrackBar tkbIntervaloPassos;
        private System.Windows.Forms.GroupBox gpbSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCaractere;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmb_Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_code;
        private System.Windows.Forms.Label lblVelocidade;
        private System.Windows.Forms.Label lblBinarioParaByte;
        private System.Windows.Forms.RichTextBox rtbSaidaBytes;
        private System.Windows.Forms.Panel panInformacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfoReducao;
        private System.Windows.Forms.Label lblInfoEntrada;
    }
}