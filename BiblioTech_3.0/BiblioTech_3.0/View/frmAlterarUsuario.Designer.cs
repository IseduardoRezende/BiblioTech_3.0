﻿namespace BiblioTech_3._0.View
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblBordaEmail = new System.Windows.Forms.Label();
            this.lblBordaNome = new System.Windows.Forms.Label();
            this.lblBordaTelefone = new System.Windows.Forms.Label();
            this.btnexibirEmail2 = new System.Windows.Forms.Button();
            this.btnexibirTelefone2 = new System.Windows.Forms.Button();
            this.pnlTelefone2 = new System.Windows.Forms.Panel();
            this.btnOcultarTelefone2 = new System.Windows.Forms.Button();
            this.txtTelefone_Opcional = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.lblBordaTelefone2 = new System.Windows.Forms.Label();
            this.pnlEmail2 = new System.Windows.Forms.Panel();
            this.txtEmail_Opcional = new System.Windows.Forms.TextBox();
            this.btnOcultarEmail2 = new System.Windows.Forms.Button();
            this.lblBordaEmail2 = new System.Windows.Forms.Label();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.btnArquivar = new System.Windows.Forms.Button();
            this.pnlTelefone2.SuspendLayout();
            this.pnlEmail2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(544, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 65;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtTelefone.Location = new System.Drawing.Point(71, 319);
            this.txtTelefone.Mask = "## #####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(338, 33);
            this.txtTelefone.TabIndex = 64;
            this.txtTelefone.Text = "11900000000";
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefone.Enter += new System.EventHandler(this.TxtTelefone_Enter);
            this.txtTelefone.Leave += new System.EventHandler(this.TxtTelefone_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(82, 176);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 20);
            this.lblEmail.TabIndex = 62;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Visible = false;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(80, 296);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(84, 20);
            this.lblTelefone.TabIndex = 61;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(80, 75);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 60;
            this.lblNome.Text = "Nome:";
            this.lblNome.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtEmail.Location = new System.Drawing.Point(70, 199);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(338, 33);
            this.txtEmail.TabIndex = 59;
            this.txtEmail.Text = "emaildousuario@gmial.com";
            this.txtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(487, 446);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(336, 49);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.Location = new System.Drawing.Point(47, 446);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(321, 49);
            this.btnAlterar.TabIndex = 56;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtNome.Location = new System.Drawing.Point(70, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(721, 33);
            this.txtNome.TabIndex = 58;
            this.txtNome.Text = "Nome do Usuario:";
            this.txtNome.Enter += new System.EventHandler(this.TxtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // lblBordaEmail
            // 
            this.lblBordaEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaEmail.Location = new System.Drawing.Point(67, 196);
            this.lblBordaEmail.Name = "lblBordaEmail";
            this.lblBordaEmail.Size = new System.Drawing.Size(345, 39);
            this.lblBordaEmail.TabIndex = 63;
            // 
            // lblBordaNome
            // 
            this.lblBordaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaNome.Location = new System.Drawing.Point(67, 95);
            this.lblBordaNome.Name = "lblBordaNome";
            this.lblBordaNome.Size = new System.Drawing.Size(728, 39);
            this.lblBordaNome.TabIndex = 67;
            // 
            // lblBordaTelefone
            // 
            this.lblBordaTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaTelefone.Location = new System.Drawing.Point(68, 316);
            this.lblBordaTelefone.Name = "lblBordaTelefone";
            this.lblBordaTelefone.Size = new System.Drawing.Size(344, 39);
            this.lblBordaTelefone.TabIndex = 66;
            // 
            // btnexibirEmail2
            // 
            this.btnexibirEmail2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnexibirEmail2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexibirEmail2.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexibirEmail2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexibirEmail2.Location = new System.Drawing.Point(423, 191);
            this.btnexibirEmail2.Name = "btnexibirEmail2";
            this.btnexibirEmail2.Size = new System.Drawing.Size(50, 49);
            this.btnexibirEmail2.TabIndex = 70;
            this.btnexibirEmail2.Text = "+";
            this.btnexibirEmail2.UseVisualStyleBackColor = false;
            this.btnexibirEmail2.Click += new System.EventHandler(this.BtnexibirEmail2_Click);
            // 
            // btnexibirTelefone2
            // 
            this.btnexibirTelefone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnexibirTelefone2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexibirTelefone2.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexibirTelefone2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexibirTelefone2.Location = new System.Drawing.Point(424, 311);
            this.btnexibirTelefone2.Name = "btnexibirTelefone2";
            this.btnexibirTelefone2.Size = new System.Drawing.Size(50, 49);
            this.btnexibirTelefone2.TabIndex = 71;
            this.btnexibirTelefone2.Text = "+";
            this.btnexibirTelefone2.UseVisualStyleBackColor = false;
            this.btnexibirTelefone2.Click += new System.EventHandler(this.BtnexibirTelefone2_Click);
            // 
            // pnlTelefone2
            // 
            this.pnlTelefone2.Controls.Add(this.btnOcultarTelefone2);
            this.pnlTelefone2.Controls.Add(this.txtTelefone_Opcional);
            this.pnlTelefone2.Controls.Add(this.lblTelefone2);
            this.pnlTelefone2.Controls.Add(this.lblBordaTelefone2);
            this.pnlTelefone2.Location = new System.Drawing.Point(432, 280);
            this.pnlTelefone2.Name = "pnlTelefone2";
            this.pnlTelefone2.Size = new System.Drawing.Size(405, 115);
            this.pnlTelefone2.TabIndex = 69;
            this.pnlTelefone2.Visible = false;
            // 
            // btnOcultarTelefone2
            // 
            this.btnOcultarTelefone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnOcultarTelefone2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOcultarTelefone2.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultarTelefone2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOcultarTelefone2.Location = new System.Drawing.Point(341, 75);
            this.btnOcultarTelefone2.Name = "btnOcultarTelefone2";
            this.btnOcultarTelefone2.Size = new System.Drawing.Size(50, 36);
            this.btnOcultarTelefone2.TabIndex = 57;
            this.btnOcultarTelefone2.Text = "-";
            this.btnOcultarTelefone2.UseVisualStyleBackColor = false;
            this.btnOcultarTelefone2.Click += new System.EventHandler(this.BtnOcultarTelefone2_Click);
            // 
            // txtTelefone_Opcional
            // 
            this.txtTelefone_Opcional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtTelefone_Opcional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone_Opcional.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone_Opcional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtTelefone_Opcional.Location = new System.Drawing.Point(21, 39);
            this.txtTelefone_Opcional.Mask = "## #####-####";
            this.txtTelefone_Opcional.Name = "txtTelefone_Opcional";
            this.txtTelefone_Opcional.Size = new System.Drawing.Size(338, 33);
            this.txtTelefone_Opcional.TabIndex = 47;
            this.txtTelefone_Opcional.Text = "11900000000";
            this.txtTelefone_Opcional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefone_Opcional.Enter += new System.EventHandler(this.TxtTelefone2_Enter);
            this.txtTelefone_Opcional.Leave += new System.EventHandler(this.TxtTelefone2_Leave);
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.ForeColor = System.Drawing.Color.White;
            this.lblTelefone2.Location = new System.Drawing.Point(43, 16);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(99, 20);
            this.lblTelefone2.TabIndex = 48;
            this.lblTelefone2.Text = "Telefone 2:";
            this.lblTelefone2.Visible = false;
            // 
            // lblBordaTelefone2
            // 
            this.lblBordaTelefone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaTelefone2.Location = new System.Drawing.Point(18, 36);
            this.lblBordaTelefone2.Name = "lblBordaTelefone2";
            this.lblBordaTelefone2.Size = new System.Drawing.Size(345, 39);
            this.lblBordaTelefone2.TabIndex = 49;
            // 
            // pnlEmail2
            // 
            this.pnlEmail2.Controls.Add(this.txtEmail_Opcional);
            this.pnlEmail2.Controls.Add(this.btnOcultarEmail2);
            this.pnlEmail2.Controls.Add(this.lblBordaEmail2);
            this.pnlEmail2.Controls.Add(this.lblEmail2);
            this.pnlEmail2.Location = new System.Drawing.Point(432, 162);
            this.pnlEmail2.Name = "pnlEmail2";
            this.pnlEmail2.Size = new System.Drawing.Size(405, 122);
            this.pnlEmail2.TabIndex = 68;
            this.pnlEmail2.Visible = false;
            // 
            // txtEmail_Opcional
            // 
            this.txtEmail_Opcional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtEmail_Opcional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail_Opcional.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail_Opcional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtEmail_Opcional.Location = new System.Drawing.Point(25, 37);
            this.txtEmail_Opcional.Name = "txtEmail_Opcional";
            this.txtEmail_Opcional.Size = new System.Drawing.Size(338, 33);
            this.txtEmail_Opcional.TabIndex = 43;
            this.txtEmail_Opcional.Text = "email2dousuario@gmail.com";
            this.txtEmail_Opcional.Enter += new System.EventHandler(this.TxtEmail2_Enter);
            this.txtEmail_Opcional.Leave += new System.EventHandler(this.TxtEmail2_Leave);
            // 
            // btnOcultarEmail2
            // 
            this.btnOcultarEmail2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnOcultarEmail2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOcultarEmail2.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultarEmail2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOcultarEmail2.Location = new System.Drawing.Point(341, 76);
            this.btnOcultarEmail2.Name = "btnOcultarEmail2";
            this.btnOcultarEmail2.Size = new System.Drawing.Size(50, 36);
            this.btnOcultarEmail2.TabIndex = 56;
            this.btnOcultarEmail2.Text = "-";
            this.btnOcultarEmail2.UseVisualStyleBackColor = false;
            this.btnOcultarEmail2.Click += new System.EventHandler(this.BtnOcultarEmail2_Click);
            // 
            // lblBordaEmail2
            // 
            this.lblBordaEmail2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaEmail2.Location = new System.Drawing.Point(22, 34);
            this.lblBordaEmail2.Name = "lblBordaEmail2";
            this.lblBordaEmail2.Size = new System.Drawing.Size(345, 40);
            this.lblBordaEmail2.TabIndex = 45;
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail2.ForeColor = System.Drawing.Color.White;
            this.lblEmail2.Location = new System.Drawing.Point(43, 14);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(73, 20);
            this.lblEmail2.TabIndex = 44;
            this.lblEmail2.Text = "Email 2:";
            this.lblEmail2.Visible = false;
            // 
            // btnArquivar
            // 
            this.btnArquivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnArquivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArquivar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnArquivar.Location = new System.Drawing.Point(731, 27);
            this.btnArquivar.Name = "btnArquivar";
            this.btnArquivar.Size = new System.Drawing.Size(135, 37);
            this.btnArquivar.TabIndex = 72;
            this.btnArquivar.Text = "Arquivar";
            this.btnArquivar.UseVisualStyleBackColor = false;
            this.btnArquivar.Click += new System.EventHandler(this.BtnArquivar_Click);
            // 
            // frmAlterarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(889, 527);
            this.Controls.Add(this.btnArquivar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblBordaEmail);
            this.Controls.Add(this.lblBordaNome);
            this.Controls.Add(this.lblBordaTelefone);
            this.Controls.Add(this.btnexibirEmail2);
            this.Controls.Add(this.btnexibirTelefone2);
            this.Controls.Add(this.pnlTelefone2);
            this.Controls.Add(this.pnlEmail2);
            this.Name = "frmAlterarUsuario";
            this.Load += new System.EventHandler(this.FrmAlterarUsuario_Load);
            this.pnlTelefone2.ResumeLayout(false);
            this.pnlTelefone2.PerformLayout();
            this.pnlEmail2.ResumeLayout(false);
            this.pnlEmail2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblBordaEmail;
        private System.Windows.Forms.Label lblBordaNome;
        private System.Windows.Forms.Label lblBordaTelefone;
        private System.Windows.Forms.Button btnexibirEmail2;
        private System.Windows.Forms.Button btnexibirTelefone2;
        private System.Windows.Forms.Panel pnlTelefone2;
        private System.Windows.Forms.Button btnOcultarTelefone2;
        private System.Windows.Forms.MaskedTextBox txtTelefone_Opcional;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Label lblBordaTelefone2;
        private System.Windows.Forms.Panel pnlEmail2;
        private System.Windows.Forms.TextBox txtEmail_Opcional;
        private System.Windows.Forms.Button btnOcultarEmail2;
        private System.Windows.Forms.Label lblBordaEmail2;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.Button btnArquivar;
    }
}