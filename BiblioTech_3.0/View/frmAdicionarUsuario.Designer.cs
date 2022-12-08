namespace BiblioTech_3._0
{
    partial class frmAdicionarUsuario
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblBordaNome = new System.Windows.Forms.Label();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.lblBordaEmail2 = new System.Windows.Forms.Label();
            this.btnOcultarEmail2 = new System.Windows.Forms.Button();
            this.txtEmail_Opcional = new System.Windows.Forms.TextBox();
            this.pnlEmail2 = new System.Windows.Forms.Panel();
            this.lblBordaTelefone2 = new System.Windows.Forms.Label();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.txtTelefone_Opcional = new System.Windows.Forms.MaskedTextBox();
            this.btnOcultarTelefone2 = new System.Windows.Forms.Button();
            this.pnlTelefone2 = new System.Windows.Forms.Panel();
            this.btnexibirTelefone2 = new System.Windows.Forms.Button();
            this.lblBordaTelefone = new System.Windows.Forms.Label();
            this.lblBordaEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.btnexibirEmail2 = new System.Windows.Forms.Button();
            this.pnlEmail2.SuspendLayout();
            this.pnlTelefone2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(81)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.Location = new System.Drawing.Point(81, 484);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(304, 58);
            this.btnAdicionar.TabIndex = 20;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(81)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(486, 484);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(304, 58);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.txtNome.Location = new System.Drawing.Point(67, 137);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(721, 28);
            this.txtNome.TabIndex = 22;
            this.txtNome.Text = "Nome do Usuário:";
            this.txtNome.Enter += new System.EventHandler(this.TxtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(77, 111);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 21);
            this.lblNome.TabIndex = 37;
            this.lblNome.Text = "Nome:";
            // 
            // lblBordaNome
            // 
            this.lblBordaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaNome.Location = new System.Drawing.Point(65, 135);
            this.lblBordaNome.Name = "lblBordaNome";
            this.lblBordaNome.Size = new System.Drawing.Size(725, 33);
            this.lblBordaNome.TabIndex = 51;
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail2.ForeColor = System.Drawing.Color.White;
            this.lblEmail2.Location = new System.Drawing.Point(43, 14);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(70, 21);
            this.lblEmail2.TabIndex = 44;
            this.lblEmail2.Text = "Email 2:";
            // 
            // lblBordaEmail2
            // 
            this.lblBordaEmail2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaEmail2.Location = new System.Drawing.Point(23, 38);
            this.lblBordaEmail2.Name = "lblBordaEmail2";
            this.lblBordaEmail2.Size = new System.Drawing.Size(342, 32);
            this.lblBordaEmail2.TabIndex = 45;
            // 
            // btnOcultarEmail2
            // 
            this.btnOcultarEmail2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnOcultarEmail2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOcultarEmail2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnOcultarEmail2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOcultarEmail2.Location = new System.Drawing.Point(341, 76);
            this.btnOcultarEmail2.Name = "btnOcultarEmail2";
            this.btnOcultarEmail2.Size = new System.Drawing.Size(50, 36);
            this.btnOcultarEmail2.TabIndex = 56;
            this.btnOcultarEmail2.Text = "-";
            this.btnOcultarEmail2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOcultarEmail2.UseVisualStyleBackColor = false;
            this.btnOcultarEmail2.Click += new System.EventHandler(this.BtnOcultarEmail2_Click);
            // 
            // txtEmail_Opcional
            // 
            this.txtEmail_Opcional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtEmail_Opcional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail_Opcional.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail_Opcional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.txtEmail_Opcional.Location = new System.Drawing.Point(25, 40);
            this.txtEmail_Opcional.Name = "txtEmail_Opcional";
            this.txtEmail_Opcional.Size = new System.Drawing.Size(338, 28);
            this.txtEmail_Opcional.TabIndex = 43;
            this.txtEmail_Opcional.Text = "email2dousuario@gmail.com";
            this.txtEmail_Opcional.Enter += new System.EventHandler(this.TxtEmail2_Enter);
            this.txtEmail_Opcional.Leave += new System.EventHandler(this.TxtEmail2_Leave);
            // 
            // pnlEmail2
            // 
            this.pnlEmail2.Controls.Add(this.txtEmail_Opcional);
            this.pnlEmail2.Controls.Add(this.btnOcultarEmail2);
            this.pnlEmail2.Controls.Add(this.lblBordaEmail2);
            this.pnlEmail2.Controls.Add(this.lblEmail2);
            this.pnlEmail2.Location = new System.Drawing.Point(415, 198);
            this.pnlEmail2.Name = "pnlEmail2";
            this.pnlEmail2.Size = new System.Drawing.Size(405, 122);
            this.pnlEmail2.TabIndex = 52;
            this.pnlEmail2.Visible = false;
            // 
            // lblBordaTelefone2
            // 
            this.lblBordaTelefone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaTelefone2.Location = new System.Drawing.Point(19, 40);
            this.lblBordaTelefone2.Name = "lblBordaTelefone2";
            this.lblBordaTelefone2.Size = new System.Drawing.Size(342, 32);
            this.lblBordaTelefone2.TabIndex = 49;
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.ForeColor = System.Drawing.Color.White;
            this.lblTelefone2.Location = new System.Drawing.Point(43, 16);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(94, 21);
            this.lblTelefone2.TabIndex = 48;
            this.lblTelefone2.Text = "Telefone 2:";
            // 
            // txtTelefone_Opcional
            // 
            this.txtTelefone_Opcional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtTelefone_Opcional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone_Opcional.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone_Opcional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.txtTelefone_Opcional.Location = new System.Drawing.Point(21, 42);
            this.txtTelefone_Opcional.Mask = "## #####-####";
            this.txtTelefone_Opcional.Name = "txtTelefone_Opcional";
            this.txtTelefone_Opcional.Size = new System.Drawing.Size(338, 28);
            this.txtTelefone_Opcional.TabIndex = 47;
            this.txtTelefone_Opcional.Text = "11900000000";
            this.txtTelefone_Opcional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefone_Opcional.Enter += new System.EventHandler(this.TxtTelefone2_Enter);
            this.txtTelefone_Opcional.Leave += new System.EventHandler(this.TxtTelefone2_Leave);
            // 
            // btnOcultarTelefone2
            // 
            this.btnOcultarTelefone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnOcultarTelefone2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOcultarTelefone2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnOcultarTelefone2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOcultarTelefone2.Location = new System.Drawing.Point(341, 75);
            this.btnOcultarTelefone2.Name = "btnOcultarTelefone2";
            this.btnOcultarTelefone2.Size = new System.Drawing.Size(50, 36);
            this.btnOcultarTelefone2.TabIndex = 57;
            this.btnOcultarTelefone2.Text = "-";
            this.btnOcultarTelefone2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOcultarTelefone2.UseVisualStyleBackColor = false;
            this.btnOcultarTelefone2.Click += new System.EventHandler(this.BtnOcultarTelefone2_Click);
            // 
            // pnlTelefone2
            // 
            this.pnlTelefone2.Controls.Add(this.btnOcultarTelefone2);
            this.pnlTelefone2.Controls.Add(this.txtTelefone_Opcional);
            this.pnlTelefone2.Controls.Add(this.lblTelefone2);
            this.pnlTelefone2.Controls.Add(this.lblBordaTelefone2);
            this.pnlTelefone2.Location = new System.Drawing.Point(415, 316);
            this.pnlTelefone2.Name = "pnlTelefone2";
            this.pnlTelefone2.Size = new System.Drawing.Size(405, 115);
            this.pnlTelefone2.TabIndex = 53;
            this.pnlTelefone2.Visible = false;
            // 
            // btnexibirTelefone2
            // 
            this.btnexibirTelefone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnexibirTelefone2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexibirTelefone2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnexibirTelefone2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexibirTelefone2.Location = new System.Drawing.Point(428, 347);
            this.btnexibirTelefone2.Name = "btnexibirTelefone2";
            this.btnexibirTelefone2.Size = new System.Drawing.Size(50, 49);
            this.btnexibirTelefone2.TabIndex = 55;
            this.btnexibirTelefone2.Text = "+";
            this.btnexibirTelefone2.UseVisualStyleBackColor = false;
            this.btnexibirTelefone2.Click += new System.EventHandler(this.BtnTelefone2_Click);
            // 
            // lblBordaTelefone
            // 
            this.lblBordaTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaTelefone.Location = new System.Drawing.Point(66, 356);
            this.lblBordaTelefone.Name = "lblBordaTelefone";
            this.lblBordaTelefone.Size = new System.Drawing.Size(342, 32);
            this.lblBordaTelefone.TabIndex = 50;
            // 
            // lblBordaEmail
            // 
            this.lblBordaEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaEmail.Location = new System.Drawing.Point(65, 236);
            this.lblBordaEmail.Name = "lblBordaEmail";
            this.lblBordaEmail.Size = new System.Drawing.Size(342, 32);
            this.lblBordaEmail.TabIndex = 41;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.txtEmail.Location = new System.Drawing.Point(67, 238);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(338, 28);
            this.txtEmail.TabIndex = 34;
            this.txtEmail.Text = "emaildousuario@gmial.com";
            this.txtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(77, 332);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(81, 21);
            this.lblTelefone.TabIndex = 38;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(79, 212);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 21);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.txtTelefone.Location = new System.Drawing.Point(68, 358);
            this.txtTelefone.Mask = "## #####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(338, 28);
            this.txtTelefone.TabIndex = 42;
            this.txtTelefone.Text = "11900000000";
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefone.Enter += new System.EventHandler(this.TxtTelefone_Enter);
            this.txtTelefone.Leave += new System.EventHandler(this.TxtTelefone_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(541, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 46;
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(302, 56);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(328, 35);
            this.lblTituloForm.TabIndex = 115;
            this.lblTituloForm.Text = "CADASTRO DE USUÁRIO";
            // 
            // btnexibirEmail2
            // 
            this.btnexibirEmail2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnexibirEmail2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexibirEmail2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnexibirEmail2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexibirEmail2.Location = new System.Drawing.Point(428, 227);
            this.btnexibirEmail2.Name = "btnexibirEmail2";
            this.btnexibirEmail2.Size = new System.Drawing.Size(50, 49);
            this.btnexibirEmail2.TabIndex = 54;
            this.btnexibirEmail2.Text = "+";
            this.btnexibirEmail2.UseVisualStyleBackColor = false;
            this.btnexibirEmail2.Click += new System.EventHandler(this.BtnEmail_Click);
            // 
            // frmAdicionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(889, 599);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblBordaEmail);
            this.Controls.Add(this.lblBordaNome);
            this.Controls.Add(this.lblBordaTelefone);
            this.Controls.Add(this.btnexibirEmail2);
            this.Controls.Add(this.btnexibirTelefone2);
            this.Controls.Add(this.pnlTelefone2);
            this.Controls.Add(this.pnlEmail2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdicionarUsuario";
            this.Load += new System.EventHandler(this.frmAdicionarUsuario_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmAdicionarUsuario_Paint);
            this.pnlEmail2.ResumeLayout(false);
            this.pnlEmail2.PerformLayout();
            this.pnlTelefone2.ResumeLayout(false);
            this.pnlTelefone2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblBordaNome;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.Label lblBordaEmail2;
        private System.Windows.Forms.Button btnOcultarEmail2;
        private System.Windows.Forms.TextBox txtEmail_Opcional;
        public System.Windows.Forms.Panel pnlEmail2;
        private System.Windows.Forms.Label lblBordaTelefone2;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.MaskedTextBox txtTelefone_Opcional;
        private System.Windows.Forms.Button btnOcultarTelefone2;
        private System.Windows.Forms.Panel pnlTelefone2;
        private System.Windows.Forms.Button btnexibirTelefone2;
        private System.Windows.Forms.Label lblBordaTelefone;
        private System.Windows.Forms.Label lblBordaEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTituloForm;
        public System.Windows.Forms.Button btnexibirEmail2;
    }
}