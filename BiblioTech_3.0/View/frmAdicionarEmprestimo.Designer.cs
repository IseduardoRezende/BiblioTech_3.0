namespace BiblioTech_3._0.View
{
    partial class frmAdicionarEmprestimo
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
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pnUsuario = new System.Windows.Forms.Panel();
            this.dgvAddUsuario = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBNText = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnConfirmarEmprestimo = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblBordaNome = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUsuarioEscolhido = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cdpData = new BiblioTech_3._0.CustomComponents.CustomDatePicker();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerenciar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerenciar.Location = new System.Drawing.Point(598, 276);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(141, 25);
            this.btnGerenciar.TabIndex = 92;
            this.btnGerenciar.Text = "Gerenciar";
            this.btnGerenciar.UseVisualStyleBackColor = false;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemover.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemover.Location = new System.Drawing.Point(382, 425);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(131, 33);
            this.btnRemover.TabIndex = 86;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.Location = new System.Drawing.Point(729, 563);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(131, 33);
            this.btnAdicionar.TabIndex = 85;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Visible = false;
            // 
            // pnUsuario
            // 
            this.pnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.pnUsuario.Controls.Add(this.dgvAddUsuario);
            this.pnUsuario.Location = new System.Drawing.Point(183, 318);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(560, 92);
            this.pnUsuario.TabIndex = 84;
            // 
            // dgvAddUsuario
            // 
            this.dgvAddUsuario.AllowUserToAddRows = false;
            this.dgvAddUsuario.AllowUserToDeleteRows = false;
            this.dgvAddUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.dgvAddUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddUsuario.EnableHeadersVisualStyles = false;
            this.dgvAddUsuario.Location = new System.Drawing.Point(0, 0);
            this.dgvAddUsuario.Name = "dgvAddUsuario";
            this.dgvAddUsuario.ReadOnly = true;
            this.dgvAddUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddUsuario.RowHeadersWidth = 70;
            this.dgvAddUsuario.Size = new System.Drawing.Size(560, 92);
            this.dgvAddUsuario.TabIndex = 115;
            this.dgvAddUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddUsuario_CellClick);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(401, 281);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 20);
            this.lblUsuario.TabIndex = 83;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.White;
            this.lblISBN.Location = new System.Drawing.Point(249, 160);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(124, 20);
            this.lblISBN.TabIndex = 81;
            this.lblISBN.Text = "ISBN do Livro:";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtISBN.Enabled = false;
            this.txtISBN.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtISBN.Location = new System.Drawing.Point(229, 193);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(222, 33);
            this.txtISBN.TabIndex = 80;
            this.txtISBN.Text = "ISBN do Livro:";
            this.txtISBN.Enter += new System.EventHandler(this.txtISBN_Enter);
            this.txtISBN.Leave += new System.EventHandler(this.txtISBN_Leave);
            // 
            // lblISBNText
            // 
            this.lblISBNText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblISBNText.Enabled = false;
            this.lblISBNText.Location = new System.Drawing.Point(226, 190);
            this.lblISBNText.Name = "lblISBNText";
            this.lblISBNText.Size = new System.Drawing.Size(225, 36);
            this.lblISBNText.TabIndex = 82;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(387, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(126, 20);
            this.lblNome.TabIndex = 78;
            this.lblNome.Text = "Título do Livro:";
            // 
            // btnConfirmarEmprestimo
            // 
            this.btnConfirmarEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnConfirmarEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarEmprestimo.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarEmprestimo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmarEmprestimo.Location = new System.Drawing.Point(214, 477);
            this.btnConfirmarEmprestimo.Name = "btnConfirmarEmprestimo";
            this.btnConfirmarEmprestimo.Size = new System.Drawing.Size(464, 49);
            this.btnConfirmarEmprestimo.TabIndex = 76;
            this.btnConfirmarEmprestimo.Text = "Confimar";
            this.btnConfirmarEmprestimo.UseVisualStyleBackColor = false;
            this.btnConfirmarEmprestimo.Click += new System.EventHandler(this.btnConfirmarEmprestimo_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtNome.Location = new System.Drawing.Point(142, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(597, 33);
            this.txtNome.TabIndex = 77;
            this.txtNome.Text = "Título do Livro:";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // lblBordaNome
            // 
            this.lblBordaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaNome.Enabled = false;
            this.lblBordaNome.Location = new System.Drawing.Point(139, 82);
            this.lblBordaNome.Name = "lblBordaNome";
            this.lblBordaNome.Size = new System.Drawing.Size(604, 39);
            this.lblBordaNome.TabIndex = 79;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(547, 160);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(147, 20);
            this.lblData.TabIndex = 94;
            this.lblData.Text = "Data da Entrega:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 16F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(338, 541);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(228, 41);
            this.btnCancelar.TabIndex = 110;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lblUsuarioEscolhido
            // 
            this.lblUsuarioEscolhido.AutoSize = true;
            this.lblUsuarioEscolhido.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEscolhido.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioEscolhido.Location = new System.Drawing.Point(21, 431);
            this.lblUsuarioEscolhido.Name = "lblUsuarioEscolhido";
            this.lblUsuarioEscolhido.Size = new System.Drawing.Size(0, 19);
            this.lblUsuarioEscolhido.TabIndex = 111;
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusca.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBusca.Location = new System.Drawing.Point(780, 12);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(89, 30);
            this.btnBusca.TabIndex = 113;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Visible = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusca.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.Color.White;
            this.txtBusca.Location = new System.Drawing.Point(508, 12);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(249, 26);
            this.txtBusca.TabIndex = 112;
            this.txtBusca.Visible = false;
            this.txtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusca_KeyPress);
            // 
            // cdpData
            // 
            this.cdpData.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cdpData.BorderSize = 0;
            this.cdpData.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdpData.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.cdpData.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.cdpData.CalendarTitleBackColor = System.Drawing.Color.Coral;
            this.cdpData.CalendarTitleForeColor = System.Drawing.Color.Peru;
            this.cdpData.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.cdpData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cdpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cdpData.Location = new System.Drawing.Point(535, 190);
            this.cdpData.MinimumSize = new System.Drawing.Size(4, 35);
            this.cdpData.Name = "cdpData";
            this.cdpData.Size = new System.Drawing.Size(179, 35);
            this.cdpData.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.cdpData.TabIndex = 93;
            this.cdpData.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(12, 33);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(176, 19);
            this.lblTituloForm.TabIndex = 114;
            this.lblTituloForm.Text = "Cadastro de Empréstimo";
            // 
            // frmAdicionarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(905, 608);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lblUsuarioEscolhido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cdpData);
            this.Controls.Add(this.btnGerenciar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.pnUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblISBNText);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnConfirmarEmprestimo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblBordaNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdicionarEmprestimo";
            this.Text = "frmAdicionarEmprestimo";
            this.Load += new System.EventHandler(this.frmAdicionarEmprestimo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmAdicionarEmprestimo_Paint);
            this.pnUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel pnUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBNText;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnConfirmarEmprestimo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblBordaNome;
        private CustomComponents.CustomDatePicker cdpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUsuarioEscolhido;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvAddUsuario;
        private System.Windows.Forms.Label lblTituloForm;
    }
}