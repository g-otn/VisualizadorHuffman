﻿namespace VisualizadorHuffman
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nó0");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node1");
            this.gpbEntrada = new System.Windows.Forms.GroupBox();
            this.rtbEntrada = new System.Windows.Forms.RichTextBox();
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
            this.lblInfoSaida = new System.Windows.Forms.Label();
            this.lblInfoDiferenca = new System.Windows.Forms.Label();
            this.lblInfoEntrada = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.lnkGitHubLink = new System.Windows.Forms.LinkLabel();
            this.timerPasso = new System.Windows.Forms.Timer(this.components);
            this.ttpAvisoANSI = new System.Windows.Forms.ToolTip(this.components);
            this.lblEstado = new System.Windows.Forms.Label();
            this.gpbEntrada.SuspendLayout();
            this.gpbControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbIntervaloPassos)).BeginInit();
            this.gpbPassos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteres)).BeginInit();
            this.gpbSaida.SuspendLayout();
            this.panInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbEntrada
            // 
            this.gpbEntrada.Controls.Add(this.rtbEntrada);
            this.gpbEntrada.Controls.Add(this.btnAbrirArquivo);
            this.gpbEntrada.Controls.Add(this.txtCaminhoArquivo);
            this.gpbEntrada.Location = new System.Drawing.Point(12, 12);
            this.gpbEntrada.Name = "gpbEntrada";
            this.gpbEntrada.Padding = new System.Windows.Forms.Padding(6);
            this.gpbEntrada.Size = new System.Drawing.Size(433, 174);
            this.gpbEntrada.TabIndex = 2;
            this.gpbEntrada.TabStop = false;
            this.gpbEntrada.Text = "Entrada";
            // 
            // rtbEntrada
            // 
            this.rtbEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEntrada.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEntrada.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rtbEntrada.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.rtbEntrada.Location = new System.Drawing.Point(9, 51);
            this.rtbEntrada.Name = "rtbEntrada";
            this.rtbEntrada.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbEntrada.Size = new System.Drawing.Size(415, 114);
            this.rtbEntrada.TabIndex = 7;
            this.rtbEntrada.Text = "Digite alguma coisa...";
            this.ttpAvisoANSI.SetToolTip(this.rtbEntrada, "É recomendado inserir caracteres codificados \r\nem ANSI / Windows-1252. Caracteres" +
        " não \r\nreconhecidos serão substituidos por \'?\'.");
            this.rtbEntrada.Enter += new System.EventHandler(this.rtbEntrada_Enter);
            this.rtbEntrada.Leave += new System.EventHandler(this.rtbEntrada_Leave);
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Location = new System.Drawing.Point(9, 22);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(113, 23);
            this.btnAbrirArquivo.TabIndex = 5;
            this.btnAbrirArquivo.Text = "Abrir Arquivo";
            this.ttpAvisoANSI.SetToolTip(this.btnAbrirArquivo, "É recomendado selecionar arquivos codificados \r\nem ANSI / Windows-1252. Caractere" +
        "s não \r\nreconhecidos serão substituidos por \'?\'.\r\n");
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
            this.ttpAvisoANSI.SetToolTip(this.txtCaminhoArquivo, "É recomendado selecionar arquivos codificados \r\nem ANSI / Windows-1252. Caractere" +
        "s não \r\nreconhecidos serão substituidos por \'?\'.");
            this.txtCaminhoArquivo.Leave += new System.EventHandler(this.txtCaminhoArquivo_Leave);
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
            this.gpbControle.Size = new System.Drawing.Size(537, 57);
            this.gpbControle.TabIndex = 3;
            this.gpbControle.TabStop = false;
            this.gpbControle.Text = "Controle";
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.Location = new System.Drawing.Point(321, 18);
            this.lblVelocidade.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(105, 26);
            this.lblVelocidade.TabIndex = 8;
            this.lblVelocidade.Text = "Velocidade:\r\n750ms por passo\r\n";
            // 
            // tkbIntervaloPassos
            // 
            this.tkbIntervaloPassos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkbIntervaloPassos.AutoSize = false;
            this.tkbIntervaloPassos.LargeChange = 250;
            this.tkbIntervaloPassos.Location = new System.Drawing.Point(418, 19);
            this.tkbIntervaloPassos.Maximum = 1975;
            this.tkbIntervaloPassos.Name = "tkbIntervaloPassos";
            this.tkbIntervaloPassos.Size = new System.Drawing.Size(113, 26);
            this.tkbIntervaloPassos.SmallChange = 25;
            this.tkbIntervaloPassos.TabIndex = 11;
            this.tkbIntervaloPassos.TickFrequency = 500;
            this.tkbIntervaloPassos.Value = 1250;
            this.tkbIntervaloPassos.Scroll += new System.EventHandler(this.tkbIntervaloPassos_Scroll);
            // 
            // btnProximoPasso
            // 
            this.btnProximoPasso.Location = new System.Drawing.Point(209, 19);
            this.btnProximoPasso.Name = "btnProximoPasso";
            this.btnProximoPasso.Size = new System.Drawing.Size(94, 23);
            this.btnProximoPasso.TabIndex = 10;
            this.btnProximoPasso.Text = "Próximo Passo";
            this.btnProximoPasso.UseVisualStyleBackColor = true;
            this.btnProximoPasso.Click += new System.EventHandler(this.btnProximoPasso_Click);
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
            this.rtbSaidaBinario.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSaidaBinario.Location = new System.Drawing.Point(9, 35);
            this.rtbSaidaBinario.Name = "rtbSaidaBinario";
            this.rtbSaidaBinario.ReadOnly = true;
            this.rtbSaidaBinario.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSaidaBinario.ShowSelectionMargin = true;
            this.rtbSaidaBinario.Size = new System.Drawing.Size(415, 133);
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
            this.gpbPassos.Size = new System.Drawing.Size(537, 377);
            this.gpbPassos.TabIndex = 9;
            this.gpbPassos.TabStop = false;
            this.gpbPassos.Text = "Passos Da Compressão";
            // 
            // dgvCaracteres
            // 
            this.dgvCaracteres.AllowUserToAddRows = false;
            this.dgvCaracteres.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvCaracteres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCaracteres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCaracteres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaracteres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCaracteres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCaractere,
            this.nmb_Frequency,
            this.txt_code});
            this.dgvCaracteres.Location = new System.Drawing.Point(9, 22);
            this.dgvCaracteres.MultiSelect = false;
            this.dgvCaracteres.Name = "dgvCaracteres";
            this.dgvCaracteres.ReadOnly = true;
            this.dgvCaracteres.RowHeadersVisible = false;
            this.dgvCaracteres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvCaracteres.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCaracteres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaracteres.ShowCellErrors = false;
            this.dgvCaracteres.ShowCellToolTips = false;
            this.dgvCaracteres.ShowEditingIcon = false;
            this.dgvCaracteres.ShowRowErrors = false;
            this.dgvCaracteres.Size = new System.Drawing.Size(228, 346);
            this.dgvCaracteres.TabIndex = 10;
            // 
            // txtCaractere
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.txtCaractere.DefaultCellStyle = dataGridViewCellStyle8;
            this.txtCaractere.FillWeight = 90F;
            this.txtCaractere.HeaderText = "Caractere";
            this.txtCaractere.MinimumWidth = 20;
            this.txtCaractere.Name = "txtCaractere";
            this.txtCaractere.ReadOnly = true;
            this.txtCaractere.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtCaractere.ToolTipText = "Os caracteres distintos presentes na entrada";
            // 
            // nmb_Frequency
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.nmb_Frequency.DefaultCellStyle = dataGridViewCellStyle9;
            this.nmb_Frequency.FillWeight = 80F;
            this.nmb_Frequency.HeaderText = "Frequência";
            this.nmb_Frequency.MinimumWidth = 20;
            this.nmb_Frequency.Name = "nmb_Frequency";
            this.nmb_Frequency.ReadOnly = true;
            this.nmb_Frequency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txt_code
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.txt_code.DefaultCellStyle = dataGridViewCellStyle10;
            this.txt_code.HeaderText = "Código";
            this.txt_code.MinimumWidth = 20;
            this.txt_code.Name = "txt_code";
            this.txt_code.ReadOnly = true;
            this.txt_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // trvArvore
            // 
            this.trvArvore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvArvore.Indent = 40;
            this.trvArvore.Location = new System.Drawing.Point(243, 22);
            this.trvArvore.Name = "trvArvore";
            treeNode4.Name = "Nó0";
            treeNode4.Text = "Nó0";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Node0";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Node1";
            this.trvArvore.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.trvArvore.Size = new System.Drawing.Size(285, 346);
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
            this.gpbSaida.Location = new System.Drawing.Point(12, 192);
            this.gpbSaida.MinimumSize = new System.Drawing.Size(0, 150);
            this.gpbSaida.Name = "gpbSaida";
            this.gpbSaida.Padding = new System.Windows.Forms.Padding(6);
            this.gpbSaida.Size = new System.Drawing.Size(433, 260);
            this.gpbSaida.TabIndex = 10;
            this.gpbSaida.TabStop = false;
            this.gpbSaida.Text = "Saída";
            // 
            // lblBinarioParaByte
            // 
            this.lblBinarioParaByte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBinarioParaByte.AutoSize = true;
            this.lblBinarioParaByte.Location = new System.Drawing.Point(9, 171);
            this.lblBinarioParaByte.Name = "lblBinarioParaByte";
            this.lblBinarioParaByte.Size = new System.Drawing.Size(85, 13);
            this.lblBinarioParaByte.TabIndex = 8;
            this.lblBinarioParaByte.Text = "Binário em Bytes";
            // 
            // rtbSaidaBytes
            // 
            this.rtbSaidaBytes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSaidaBytes.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSaidaBytes.Location = new System.Drawing.Point(9, 187);
            this.rtbSaidaBytes.Name = "rtbSaidaBytes";
            this.rtbSaidaBytes.ReadOnly = true;
            this.rtbSaidaBytes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSaidaBytes.ShowSelectionMargin = true;
            this.rtbSaidaBytes.Size = new System.Drawing.Size(230, 64);
            this.rtbSaidaBytes.TabIndex = 9;
            this.rtbSaidaBytes.TabStop = false;
            this.rtbSaidaBytes.Text = "";
            // 
            // panInformacoes
            // 
            this.panInformacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panInformacoes.Controls.Add(this.lblInfoSaida);
            this.panInformacoes.Controls.Add(this.lblInfoDiferenca);
            this.panInformacoes.Controls.Add(this.lblInfoEntrada);
            this.panInformacoes.Location = new System.Drawing.Point(245, 187);
            this.panInformacoes.Name = "panInformacoes";
            this.panInformacoes.Size = new System.Drawing.Size(179, 64);
            this.panInformacoes.TabIndex = 10;
            // 
            // lblInfoSaida
            // 
            this.lblInfoSaida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoSaida.Location = new System.Drawing.Point(3, 47);
            this.lblInfoSaida.Name = "lblInfoSaida";
            this.lblInfoSaida.Size = new System.Drawing.Size(173, 13);
            this.lblInfoSaida.TabIndex = 2;
            this.lblInfoSaida.Text = "Saída:";
            // 
            // lblInfoDiferenca
            // 
            this.lblInfoDiferenca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoDiferenca.ForeColor = System.Drawing.Color.Green;
            this.lblInfoDiferenca.Location = new System.Drawing.Point(3, 25);
            this.lblInfoDiferenca.Name = "lblInfoDiferenca";
            this.lblInfoDiferenca.Size = new System.Drawing.Size(173, 13);
            this.lblInfoDiferenca.TabIndex = 1;
            this.lblInfoDiferenca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoEntrada
            // 
            this.lblInfoEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoEntrada.Location = new System.Drawing.Point(3, 3);
            this.lblInfoEntrada.Name = "lblInfoEntrada";
            this.lblInfoEntrada.Size = new System.Drawing.Size(173, 13);
            this.lblInfoEntrada.TabIndex = 0;
            this.lblInfoEntrada.Text = "Entrada:";
            // 
            // lblCreditos
            // 
            this.lblCreditos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreditos.Location = new System.Drawing.Point(257, 455);
            this.lblCreditos.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(685, 13);
            this.lblCreditos.TabIndex = 11;
            this.lblCreditos.Text = "Visualizador Huffman  -  2019  -  Gabriel Otani Pereira e Christopher Marques Cor" +
    "rêa\r\n";
            this.lblCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkGitHubLink
            // 
            this.lnkGitHubLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkGitHubLink.AutoSize = true;
            this.lnkGitHubLink.Location = new System.Drawing.Point(948, 455);
            this.lnkGitHubLink.Name = "lnkGitHubLink";
            this.lnkGitHubLink.Size = new System.Drawing.Size(40, 13);
            this.lnkGitHubLink.TabIndex = 13;
            this.lnkGitHubLink.TabStop = true;
            this.lnkGitHubLink.Text = "GitHub";
            this.lnkGitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitHubLink_LinkClicked);
            // 
            // timerPasso
            // 
            this.timerPasso.Interval = 1000;
            this.timerPasso.Tick += new System.EventHandler(this.timerPasso_Tick);
            // 
            // ttpAvisoANSI
            // 
            this.ttpAvisoANSI.AutomaticDelay = 1000;
            this.ttpAvisoANSI.ToolTipTitle = "Aviso de Codificação de Caracteres";
            this.ttpAvisoANSI.UseFading = false;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEstado.Location = new System.Drawing.Point(12, 455);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(239, 13);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado: Parado";
            // 
            // FormVisualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 477);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lnkGitHubLink);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.gpbSaida);
            this.Controls.Add(this.gpbPassos);
            this.Controls.Add(this.gpbControle);
            this.Controls.Add(this.gpbEntrada);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MinimumSize = new System.Drawing.Size(930, 425);
            this.Name = "FormVisualizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador Huffman";
            this.gpbEntrada.ResumeLayout(false);
            this.gpbEntrada.PerformLayout();
            this.gpbControle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tkbIntervaloPassos)).EndInit();
            this.gpbPassos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteres)).EndInit();
            this.gpbSaida.ResumeLayout(false);
            this.gpbSaida.PerformLayout();
            this.panInformacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbEntrada;
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
        private System.Windows.Forms.TrackBar tkbIntervaloPassos;
        private System.Windows.Forms.GroupBox gpbSaida;
        private System.Windows.Forms.Label lblVelocidade;
        private System.Windows.Forms.Label lblBinarioParaByte;
        private System.Windows.Forms.RichTextBox rtbSaidaBytes;
        private System.Windows.Forms.Panel panInformacoes;
        private System.Windows.Forms.Label lblInfoSaida;
        private System.Windows.Forms.Label lblInfoDiferenca;
        private System.Windows.Forms.Label lblInfoEntrada;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.LinkLabel lnkGitHubLink;
        private System.Windows.Forms.Timer timerPasso;
        private System.Windows.Forms.RichTextBox rtbEntrada;
        private System.Windows.Forms.ToolTip ttpAvisoANSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCaractere;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmb_Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_code;
        private System.Windows.Forms.Label lblEstado;
    }
}