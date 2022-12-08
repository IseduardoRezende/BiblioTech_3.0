namespace BiblioTech_3._0.View
{
    partial class frmAdicionarLivro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblBordaNome = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lbltISBN = new System.Windows.Forms.Label();
            this.pnAutores = new System.Windows.Forms.Panel();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.lblAutores = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.cbEditora = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnGerenciarEditora = new System.Windows.Forms.Button();
            this.btnGerenciarAutores = new System.Windows.Forms.Button();
            this.btnGerenciarGenero = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGerenciarEstante = new System.Windows.Forms.Button();
            this.cbEstante = new System.Windows.Forms.ComboBox();
            this.lblEstante = new System.Windows.Forms.Label();
            this.btnGerenciarPrateleira = new System.Windows.Forms.Button();
            this.cbPrateleira = new System.Windows.Forms.ComboBox();
            this.lblPrateleira = new System.Windows.Forms.Label();
            this.lblExemplar = new System.Windows.Forms.Label();
            this.txtExemplar = new System.Windows.Forms.TextBox();
            this.lblExemplartext = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblVolumetext = new System.Windows.Forms.Label();
            this.lblCodGenero = new System.Windows.Forms.Label();
            this.txtCDD = new System.Windows.Forms.TextBox();
            this.lblCDD = new System.Windows.Forms.Label();
            this.lblAutorSelecionado = new System.Windows.Forms.Label();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnAutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(83, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 20);
            this.lblNome.TabIndex = 55;
            this.lblNome.Text = "Título:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.Location = new System.Drawing.Point(43, 521);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(497, 49);
            this.btnAdicionar.TabIndex = 52;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtTitulo.Location = new System.Drawing.Point(29, 75);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(597, 33);
            this.txtTitulo.TabIndex = 53;
            this.txtTitulo.Text = "Título do Livro:";
            this.txtTitulo.Enter += new System.EventHandler(this.txtTitulo_Enter);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // lblBordaNome
            // 
            this.lblBordaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaNome.Location = new System.Drawing.Point(26, 72);
            this.lblBordaNome.Name = "lblBordaNome";
            this.lblBordaNome.Size = new System.Drawing.Size(604, 39);
            this.lblBordaNome.TabIndex = 61;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.White;
            this.lblISBN.Location = new System.Drawing.Point(661, 43);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(56, 20);
            this.lblISBN.TabIndex = 63;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtISBN.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtISBN.Location = new System.Drawing.Point(665, 72);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(197, 33);
            this.txtISBN.TabIndex = 62;
            this.txtISBN.Text = "ISBN do Livro:";
            this.txtISBN.Enter += new System.EventHandler(this.txtISBN_Enter);
            this.txtISBN.Leave += new System.EventHandler(this.txtISBN_Leave);
            // 
            // lbltISBN
            // 
            this.lbltISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lbltISBN.Location = new System.Drawing.Point(662, 69);
            this.lbltISBN.Name = "lbltISBN";
            this.lbltISBN.Size = new System.Drawing.Size(200, 39);
            this.lbltISBN.TabIndex = 64;
            // 
            // pnAutores
            // 
            this.pnAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.pnAutores.Controls.Add(this.dgvAutores);
            this.pnAutores.Location = new System.Drawing.Point(29, 296);
            this.pnAutores.Name = "pnAutores";
            this.pnAutores.Size = new System.Drawing.Size(291, 114);
            this.pnAutores.TabIndex = 66;
            // 
            // dgvAutores
            // 
            this.dgvAutores.AllowUserToAddRows = false;
            this.dgvAutores.AllowUserToDeleteRows = false;
            this.dgvAutores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.dgvAutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAutores.EnableHeadersVisualStyles = false;
            this.dgvAutores.Location = new System.Drawing.Point(0, 0);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.ReadOnly = true;
            this.dgvAutores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAutores.RowHeadersWidth = 50;
            this.dgvAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutores.Size = new System.Drawing.Size(291, 114);
            this.dgvAutores.TabIndex = 1;
            this.dgvAutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellClick);
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.BackColor = System.Drawing.Color.Transparent;
            this.lblAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutores.ForeColor = System.Drawing.Color.White;
            this.lblAutores.Location = new System.Drawing.Point(65, 263);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(84, 20);
            this.lblAutores.TabIndex = 65;
            this.lblAutores.Text = "Autor(es)";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.BackColor = System.Drawing.Color.Transparent;
            this.lblEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.ForeColor = System.Drawing.Color.White;
            this.lblEditora.Location = new System.Drawing.Point(65, 138);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(72, 20);
            this.lblEditora.TabIndex = 69;
            this.lblEditora.Text = "Editora:";
            // 
            // cbEditora
            // 
            this.cbEditora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.cbEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEditora.Font = new System.Drawing.Font("Candara", 20.25F);
            this.cbEditora.ForeColor = System.Drawing.Color.White;
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(29, 172);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(339, 41);
            this.cbEditora.TabIndex = 70;
            // 
            // cbGenero
            // 
            this.cbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbGenero.Font = new System.Drawing.Font("Candara", 20.25F);
            this.cbGenero.ForeColor = System.Drawing.Color.White;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(523, 172);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(339, 41);
            this.cbGenero.TabIndex = 72;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(564, 138);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(74, 20);
            this.lblGenero.TabIndex = 71;
            this.lblGenero.Text = "Gênero:";
            // 
            // btnGerenciarEditora
            // 
            this.btnGerenciarEditora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnGerenciarEditora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerenciarEditora.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarEditora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerenciarEditora.Location = new System.Drawing.Point(243, 137);
            this.btnGerenciarEditora.Name = "btnGerenciarEditora";
            this.btnGerenciarEditora.Size = new System.Drawing.Size(125, 25);
            this.btnGerenciarEditora.TabIndex = 73;
            this.btnGerenciarEditora.Text = "Gerenciar";
            this.btnGerenciarEditora.UseVisualStyleBackColor = false;
            this.btnGerenciarEditora.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnGerenciarAutores
            // 
            this.btnGerenciarAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnGerenciarAutores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerenciarAutores.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarAutores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerenciarAutores.Location = new System.Drawing.Point(195, 262);
            this.btnGerenciarAutores.Name = "btnGerenciarAutores";
            this.btnGerenciarAutores.Size = new System.Drawing.Size(125, 25);
            this.btnGerenciarAutores.TabIndex = 74;
            this.btnGerenciarAutores.Text = "Gerenciar";
            this.btnGerenciarAutores.UseVisualStyleBackColor = false;
            this.btnGerenciarAutores.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnGerenciarGenero
            // 
            this.btnGerenciarGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnGerenciarGenero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerenciarGenero.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarGenero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerenciarGenero.Location = new System.Drawing.Point(737, 137);
            this.btnGerenciarGenero.Name = "btnGerenciarGenero";
            this.btnGerenciarGenero.Size = new System.Drawing.Size(125, 25);
            this.btnGerenciarGenero.TabIndex = 75;
            this.btnGerenciarGenero.Text = "Gerenciar";
            this.btnGerenciarGenero.UseVisualStyleBackColor = false;
            this.btnGerenciarGenero.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(600, 521);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(230, 49);
            this.btnCancelar.TabIndex = 76;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.Button6_Click);
            // 
            // btnGerenciarEstante
            // 
            this.btnGerenciarEstante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnGerenciarEstante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerenciarEstante.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarEstante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerenciarEstante.Location = new System.Drawing.Point(747, 444);
            this.btnGerenciarEstante.Name = "btnGerenciarEstante";
            this.btnGerenciarEstante.Size = new System.Drawing.Size(83, 25);
            this.btnGerenciarEstante.TabIndex = 79;
            this.btnGerenciarEstante.Text = "Gerenciar";
            this.btnGerenciarEstante.UseVisualStyleBackColor = false;
            this.btnGerenciarEstante.Click += new System.EventHandler(this.Button7_Click);
            // 
            // cbEstante
            // 
            this.cbEstante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.cbEstante.DisplayMember = "desc_estante";
            this.cbEstante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstante.Font = new System.Drawing.Font("Candara", 20.25F);
            this.cbEstante.ForeColor = System.Drawing.Color.White;
            this.cbEstante.FormattingEnabled = true;
            this.cbEstante.Location = new System.Drawing.Point(636, 440);
            this.cbEstante.Name = "cbEstante";
            this.cbEstante.Size = new System.Drawing.Size(95, 41);
            this.cbEstante.TabIndex = 78;
            this.cbEstante.ValueMember = "id_estante";
            // 
            // lblEstante
            // 
            this.lblEstante.AutoSize = true;
            this.lblEstante.BackColor = System.Drawing.Color.Transparent;
            this.lblEstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstante.ForeColor = System.Drawing.Color.White;
            this.lblEstante.Location = new System.Drawing.Point(640, 411);
            this.lblEstante.Name = "lblEstante";
            this.lblEstante.Size = new System.Drawing.Size(77, 20);
            this.lblEstante.TabIndex = 77;
            this.lblEstante.Text = "Estante:";
            // 
            // btnGerenciarPrateleira
            // 
            this.btnGerenciarPrateleira.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnGerenciarPrateleira.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerenciarPrateleira.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarPrateleira.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerenciarPrateleira.Location = new System.Drawing.Point(747, 364);
            this.btnGerenciarPrateleira.Name = "btnGerenciarPrateleira";
            this.btnGerenciarPrateleira.Size = new System.Drawing.Size(83, 25);
            this.btnGerenciarPrateleira.TabIndex = 82;
            this.btnGerenciarPrateleira.Text = "Gerenciar";
            this.btnGerenciarPrateleira.UseVisualStyleBackColor = false;
            this.btnGerenciarPrateleira.Click += new System.EventHandler(this.Button8_Click);
            // 
            // cbPrateleira
            // 
            this.cbPrateleira.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.cbPrateleira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrateleira.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPrateleira.Font = new System.Drawing.Font("Candara", 20.25F);
            this.cbPrateleira.ForeColor = System.Drawing.Color.White;
            this.cbPrateleira.FormattingEnabled = true;
            this.cbPrateleira.Location = new System.Drawing.Point(636, 355);
            this.cbPrateleira.Name = "cbPrateleira";
            this.cbPrateleira.Size = new System.Drawing.Size(95, 41);
            this.cbPrateleira.TabIndex = 81;
            // 
            // lblPrateleira
            // 
            this.lblPrateleira.AutoSize = true;
            this.lblPrateleira.BackColor = System.Drawing.Color.Transparent;
            this.lblPrateleira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrateleira.ForeColor = System.Drawing.Color.White;
            this.lblPrateleira.Location = new System.Drawing.Point(640, 321);
            this.lblPrateleira.Name = "lblPrateleira";
            this.lblPrateleira.Size = new System.Drawing.Size(91, 20);
            this.lblPrateleira.TabIndex = 80;
            this.lblPrateleira.Text = "Prateleira:";
            // 
            // lblExemplar
            // 
            this.lblExemplar.AutoSize = true;
            this.lblExemplar.BackColor = System.Drawing.Color.Transparent;
            this.lblExemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExemplar.ForeColor = System.Drawing.Color.White;
            this.lblExemplar.Location = new System.Drawing.Point(351, 314);
            this.lblExemplar.Name = "lblExemplar";
            this.lblExemplar.Size = new System.Drawing.Size(88, 20);
            this.lblExemplar.TabIndex = 86;
            this.lblExemplar.Text = "Exemplar:";
            // 
            // txtExemplar
            // 
            this.txtExemplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtExemplar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExemplar.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExemplar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtExemplar.Location = new System.Drawing.Point(355, 346);
            this.txtExemplar.Name = "txtExemplar";
            this.txtExemplar.Size = new System.Drawing.Size(226, 33);
            this.txtExemplar.TabIndex = 85;
            this.txtExemplar.Text = "Exemplar do Livro:";
            this.txtExemplar.Enter += new System.EventHandler(this.txtExemplar_Enter);
            this.txtExemplar.Leave += new System.EventHandler(this.txtExemplar_Leave);
            // 
            // lblExemplartext
            // 
            this.lblExemplartext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblExemplartext.Location = new System.Drawing.Point(352, 343);
            this.lblExemplartext.Name = "lblExemplartext";
            this.lblExemplartext.Size = new System.Drawing.Size(229, 39);
            this.lblExemplartext.TabIndex = 87;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(351, 402);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(74, 20);
            this.lblVolume.TabIndex = 89;
            this.lblVolume.Text = "Volume:";
            // 
            // txtVolume
            // 
            this.txtVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtVolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVolume.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtVolume.Location = new System.Drawing.Point(355, 434);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(226, 33);
            this.txtVolume.TabIndex = 88;
            this.txtVolume.Text = "Volume do Livro:";
            this.txtVolume.Enter += new System.EventHandler(this.txtVolume_Enter);
            this.txtVolume.Leave += new System.EventHandler(this.txtVolume_Leave);
            // 
            // lblVolumetext
            // 
            this.lblVolumetext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblVolumetext.Location = new System.Drawing.Point(352, 431);
            this.lblVolumetext.Name = "lblVolumetext";
            this.lblVolumetext.Size = new System.Drawing.Size(229, 39);
            this.lblVolumetext.TabIndex = 90;
            // 
            // lblCodGenero
            // 
            this.lblCodGenero.AutoSize = true;
            this.lblCodGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblCodGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodGenero.ForeColor = System.Drawing.Color.White;
            this.lblCodGenero.Location = new System.Drawing.Point(351, 267);
            this.lblCodGenero.Name = "lblCodGenero";
            this.lblCodGenero.Size = new System.Drawing.Size(52, 20);
            this.lblCodGenero.TabIndex = 112;
            this.lblCodGenero.Text = "CDD:";
            // 
            // txtCDD
            // 
            this.txtCDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtCDD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCDD.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtCDD.Location = new System.Drawing.Point(422, 257);
            this.txtCDD.Name = "txtCDD";
            this.txtCDD.Size = new System.Drawing.Size(225, 33);
            this.txtCDD.TabIndex = 111;
            this.txtCDD.Text = "CDD:";
            this.txtCDD.Enter += new System.EventHandler(this.txtCodGenero_Enter);
            this.txtCDD.Leave += new System.EventHandler(this.txtCodGenero_Leave);
            // 
            // lblCDD
            // 
            this.lblCDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblCDD.Location = new System.Drawing.Point(419, 257);
            this.lblCDD.Name = "lblCDD";
            this.lblCDD.Size = new System.Drawing.Size(228, 33);
            this.lblCDD.TabIndex = 113;
            // 
            // lblAutorSelecionado
            // 
            this.lblAutorSelecionado.AutoSize = true;
            this.lblAutorSelecionado.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorSelecionado.ForeColor = System.Drawing.Color.White;
            this.lblAutorSelecionado.Location = new System.Drawing.Point(25, 431);
            this.lblAutorSelecionado.Name = "lblAutorSelecionado";
            this.lblAutorSelecionado.Size = new System.Drawing.Size(0, 19);
            this.lblAutorSelecionado.TabIndex = 114;
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(409, 27);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(131, 19);
            this.lblTituloForm.TabIndex = 115;
            this.lblTituloForm.Text = "Cadastro de  Livro";
            // 
            // frmAdicionarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(885, 588);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.lblAutorSelecionado);
            this.Controls.Add(this.lblCodGenero);
            this.Controls.Add(this.txtCDD);
            this.Controls.Add(this.lblCDD);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lblVolumetext);
            this.Controls.Add(this.lblExemplar);
            this.Controls.Add(this.txtExemplar);
            this.Controls.Add(this.lblExemplartext);
            this.Controls.Add(this.btnGerenciarPrateleira);
            this.Controls.Add(this.cbPrateleira);
            this.Controls.Add(this.lblPrateleira);
            this.Controls.Add(this.btnGerenciarEstante);
            this.Controls.Add(this.cbEstante);
            this.Controls.Add(this.lblEstante);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGerenciarGenero);
            this.Controls.Add(this.btnGerenciarAutores);
            this.Controls.Add(this.btnGerenciarEditora);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cbEditora);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.pnAutores);
            this.Controls.Add(this.lblAutores);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lbltISBN);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblBordaNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdicionarLivro";
            this.Text = "frmAdicionarLivro";
            this.Load += new System.EventHandler(this.frmAdicionarLivro_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmAdicionarLivro_Paint);
            this.pnAutores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblBordaNome;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lbltISBN;
        private System.Windows.Forms.Panel pnAutores;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.ComboBox cbEditora;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnGerenciarEditora;
        private System.Windows.Forms.Button btnGerenciarAutores;
        private System.Windows.Forms.Button btnGerenciarGenero;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGerenciarEstante;
        private System.Windows.Forms.ComboBox cbEstante;
        private System.Windows.Forms.Label lblEstante;
        private System.Windows.Forms.Button btnGerenciarPrateleira;
        private System.Windows.Forms.ComboBox cbPrateleira;
        private System.Windows.Forms.Label lblPrateleira;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.Label lblExemplar;
        private System.Windows.Forms.TextBox txtExemplar;
        private System.Windows.Forms.Label lblExemplartext;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolumetext;
        private System.Windows.Forms.Label lblCodGenero;
        private System.Windows.Forms.TextBox txtCDD;
        private System.Windows.Forms.Label lblCDD;
        private System.Windows.Forms.Label lblAutorSelecionado;
        private System.Windows.Forms.Label lblTituloForm;
    }
}