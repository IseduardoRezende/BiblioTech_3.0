namespace BiblioTech_3._0.View
{
    partial class frmAlterarUsuario
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
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblBordaEmail = new System.Windows.Forms.Label();
            this.lblBordaNome = new System.Windows.Forms.Label();
            this.lblBordaTelefone = new System.Windows.Forms.Label();
            this.btnArquivar = new System.Windows.Forms.Button();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtEmail_Opcional = new System.Windows.Forms.TextBox();
            this.lblBordaEmail2 = new System.Windows.Forms.Label();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.txtTelefone_Opcional = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.lblBordaTelefone2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.txtTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.txtTelefone.Location = new System.Drawing.Point(141, 385);
            this.txtTelefone.Mask = "## #####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(494, 28);
            this.txtTelefone.TabIndex = 64;
            this.txtTelefone.Text = "11900000000";
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone_MaskInputRejected);
            this.txtTelefone.Enter += new System.EventHandler(this.TxtTelefone_Enter);
            this.txtTelefone.Leave += new System.EventHandler(this.TxtTelefone_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(137, 203);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 20);
            this.lblEmail.TabIndex = 62;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(138, 362);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(84, 20);
            this.lblTelefone.TabIndex = 61;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(137, 118);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 60;
            this.lblNome.Text = "Nome:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.txtEmail.Location = new System.Drawing.Point(141, 226);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(494, 28);
            this.txtEmail.TabIndex = 59;
            this.txtEmail.Text = "emaildousuario@gmial.com";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(81)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(484, 577);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(234, 70);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(81)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.Location = new System.Drawing.Point(85, 577);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(344, 70);
            this.btnConfirmar.TabIndex = 56;
            this.btnConfirmar.Text = "Confimar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.txtNome.Location = new System.Drawing.Point(141, 141);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(494, 28);
            this.txtNome.TabIndex = 58;
            this.txtNome.Text = "Nome do Usuario:";
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.Enter += new System.EventHandler(this.TxtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // lblBordaEmail
            // 
            this.lblBordaEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBordaEmail.ForeColor = System.Drawing.Color.White;
            this.lblBordaEmail.Location = new System.Drawing.Point(139, 223);
            this.lblBordaEmail.Name = "lblBordaEmail";
            this.lblBordaEmail.Size = new System.Drawing.Size(500, 34);
            this.lblBordaEmail.TabIndex = 63;
            // 
            // lblBordaNome
            // 
            this.lblBordaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBordaNome.ForeColor = System.Drawing.Color.White;
            this.lblBordaNome.Location = new System.Drawing.Point(138, 138);
            this.lblBordaNome.Name = "lblBordaNome";
            this.lblBordaNome.Size = new System.Drawing.Size(500, 34);
            this.lblBordaNome.TabIndex = 67;
            // 
            // lblBordaTelefone
            // 
            this.lblBordaTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBordaTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.lblBordaTelefone.Location = new System.Drawing.Point(139, 382);
            this.lblBordaTelefone.Name = "lblBordaTelefone";
            this.lblBordaTelefone.Size = new System.Drawing.Size(500, 34);
            this.lblBordaTelefone.TabIndex = 66;
            // 
            // btnArquivar
            // 
            this.btnArquivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(81)))));
            this.btnArquivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArquivar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnArquivar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnArquivar.Location = new System.Drawing.Point(617, 26);
            this.btnArquivar.Name = "btnArquivar";
            this.btnArquivar.Size = new System.Drawing.Size(172, 69);
            this.btnArquivar.TabIndex = 72;
            this.btnArquivar.Text = "Arquivar Usuário";
            this.btnArquivar.UseVisualStyleBackColor = false;
            this.btnArquivar.Visible = false;
            this.btnArquivar.Click += new System.EventHandler(this.Arquivar);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(273, 41);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(270, 35);
            this.lblTituloForm.TabIndex = 115;
            this.lblTituloForm.Text = "PERFIL DE USUÁRIO";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(484, 577);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(235, 70);
            this.btnSair.TabIndex = 117;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(85, 577);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(344, 70);
            this.btnEditar.TabIndex = 116;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtEmail_Opcional
            // 
            this.txtEmail_Opcional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.txtEmail_Opcional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail_Opcional.Enabled = false;
            this.txtEmail_Opcional.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.txtEmail_Opcional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.txtEmail_Opcional.Location = new System.Drawing.Point(141, 302);
            this.txtEmail_Opcional.Name = "txtEmail_Opcional";
            this.txtEmail_Opcional.Size = new System.Drawing.Size(494, 28);
            this.txtEmail_Opcional.TabIndex = 118;
            this.txtEmail_Opcional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail_Opcional.TextChanged += new System.EventHandler(this.txtEmail_Opcional_TextChanged);
            this.txtEmail_Opcional.Enter += new System.EventHandler(this.TxtEmail_Opcional_Enter);
            this.txtEmail_Opcional.Leave += new System.EventHandler(this.TxtEmail_Opcional_Leave);
            // 
            // lblBordaEmail2
            // 
            this.lblBordaEmail2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBordaEmail2.ForeColor = System.Drawing.Color.White;
            this.lblBordaEmail2.Location = new System.Drawing.Point(138, 299);
            this.lblBordaEmail2.Name = "lblBordaEmail2";
            this.lblBordaEmail2.Size = new System.Drawing.Size(500, 34);
            this.lblBordaEmail2.TabIndex = 120;
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail2.ForeColor = System.Drawing.Color.White;
            this.lblEmail2.Location = new System.Drawing.Point(138, 279);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(73, 20);
            this.lblEmail2.TabIndex = 119;
            this.lblEmail2.Text = "Email 2:";
            // 
            // txtTelefone_Opcional
            // 
            this.txtTelefone_Opcional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.txtTelefone_Opcional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone_Opcional.Enabled = false;
            this.txtTelefone_Opcional.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.txtTelefone_Opcional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.txtTelefone_Opcional.Location = new System.Drawing.Point(141, 467);
            this.txtTelefone_Opcional.Mask = "## #####-####";
            this.txtTelefone_Opcional.Name = "txtTelefone_Opcional";
            this.txtTelefone_Opcional.Size = new System.Drawing.Size(494, 28);
            this.txtTelefone_Opcional.TabIndex = 122;
            this.txtTelefone_Opcional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefone_Opcional.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone_Opcional_MaskInputRejected);
            this.txtTelefone_Opcional.Enter += new System.EventHandler(this.TxtTelefone_Opcional_Enter);
            this.txtTelefone_Opcional.Leave += new System.EventHandler(this.TxtTelefone_Opcional_Leave);
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.ForeColor = System.Drawing.Color.White;
            this.lblTelefone2.Location = new System.Drawing.Point(138, 444);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(99, 20);
            this.lblTelefone2.TabIndex = 123;
            this.lblTelefone2.Text = "Telefone 2:";
            // 
            // lblBordaTelefone2
            // 
            this.lblBordaTelefone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBordaTelefone2.ForeColor = System.Drawing.Color.White;
            this.lblBordaTelefone2.Location = new System.Drawing.Point(138, 464);
            this.lblBordaTelefone2.Name = "lblBordaTelefone2";
            this.lblBordaTelefone2.Size = new System.Drawing.Size(500, 34);
            this.lblBordaTelefone2.TabIndex = 124;
            // 
            // frmAlterarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(810, 708);
            this.Controls.Add(this.txtTelefone_Opcional);
            this.Controls.Add(this.lblTelefone2);
            this.Controls.Add(this.lblBordaTelefone2);
            this.Controls.Add(this.txtEmail_Opcional);
            this.Controls.Add(this.lblBordaEmail2);
            this.Controls.Add(this.lblEmail2);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.btnArquivar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblBordaEmail);
            this.Controls.Add(this.lblBordaNome);
            this.Controls.Add(this.lblBordaTelefone);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlterarUsuario";
            this.Text = "frmAlterarUsuario";
            this.Load += new System.EventHandler(this.frmAlterarUsuario_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmAlterarUsuario_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblBordaEmail;
        private System.Windows.Forms.Label lblBordaNome;
        private System.Windows.Forms.Label lblBordaTelefone;
        private System.Windows.Forms.Button btnArquivar;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtEmail_Opcional;
        private System.Windows.Forms.Label lblBordaEmail2;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.MaskedTextBox txtTelefone_Opcional;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Label lblBordaTelefone2;
    }
}