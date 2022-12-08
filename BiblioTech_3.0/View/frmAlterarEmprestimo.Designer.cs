namespace BiblioTech_3._0.View
{
    partial class frmAlterarEmprestimo
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
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.btnGerenciarUsuario = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.dgvUsuarioEmprestimo = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblTextISBN = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblBordaNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cdpDataEntrega = new BiblioTech_3._0.CustomComponents.CustomDatePicker();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.BackColor = System.Drawing.Color.Transparent;
            this.lblDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrega.ForeColor = System.Drawing.Color.White;
            this.lblDataEntrega.Location = new System.Drawing.Point(554, 169);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(163, 20);
            this.lblDataEntrega.TabIndex = 108;
            this.lblDataEntrega.Text = "Data para Entrega:";
            // 
            // btnGerenciarUsuario
            // 
            this.btnGerenciarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnGerenciarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerenciarUsuario.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerenciarUsuario.Location = new System.Drawing.Point(625, 271);
            this.btnGerenciarUsuario.Name = "btnGerenciarUsuario";
            this.btnGerenciarUsuario.Size = new System.Drawing.Size(141, 25);
            this.btnGerenciarUsuario.TabIndex = 106;
            this.btnGerenciarUsuario.Text = "Gerenciar";
            this.btnGerenciarUsuario.UseVisualStyleBackColor = false;
            this.btnGerenciarUsuario.Visible = false;
            this.btnGerenciarUsuario.Click += new System.EventHandler(this.btnGerenciarUsuario_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.pnlUsuario.Controls.Add(this.dgvUsuarioEmprestimo);
            this.pnlUsuario.Location = new System.Drawing.Point(122, 302);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(644, 120);
            this.pnlUsuario.TabIndex = 103;
            // 
            // dgvUsuarioEmprestimo
            // 
            this.dgvUsuarioEmprestimo.AllowUserToAddRows = false;
            this.dgvUsuarioEmprestimo.AllowUserToDeleteRows = false;
            this.dgvUsuarioEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarioEmprestimo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.dgvUsuarioEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarioEmprestimo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarioEmprestimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarioEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarioEmprestimo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarioEmprestimo.EnableHeadersVisualStyles = false;
            this.dgvUsuarioEmprestimo.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarioEmprestimo.Name = "dgvUsuarioEmprestimo";
            this.dgvUsuarioEmprestimo.ReadOnly = true;
            this.dgvUsuarioEmprestimo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarioEmprestimo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarioEmprestimo.RowHeadersWidth = 40;
            this.dgvUsuarioEmprestimo.Size = new System.Drawing.Size(644, 120);
            this.dgvUsuarioEmprestimo.TabIndex = 85;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(417, 272);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 20);
            this.lblUsuario.TabIndex = 102;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.White;
            this.lblISBN.Location = new System.Drawing.Point(158, 168);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(124, 20);
            this.lblISBN.TabIndex = 100;
            this.lblISBN.Text = "ISBN do Livro:";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtISBN.Enabled = false;
            this.txtISBN.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtISBN.Location = new System.Drawing.Point(138, 201);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(175, 33);
            this.txtISBN.TabIndex = 99;
            this.txtISBN.Text = "ISBN do Livro:";
            // 
            // lblTextISBN
            // 
            this.lblTextISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblTextISBN.Enabled = false;
            this.lblTextISBN.Location = new System.Drawing.Point(135, 198);
            this.lblTextISBN.Name = "lblTextISBN";
            this.lblTextISBN.Size = new System.Drawing.Size(182, 39);
            this.lblTextISBN.TabIndex = 101;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(383, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(126, 20);
            this.lblNome.TabIndex = 97;
            this.lblNome.Text = "Título do Livro:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizar.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinalizar.Location = new System.Drawing.Point(29, 439);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(464, 49);
            this.btnFinalizar.TabIndex = 95;
            this.btnFinalizar.Text = "Alterar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtTitulo.Location = new System.Drawing.Point(138, 80);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(597, 33);
            this.txtTitulo.TabIndex = 96;
            this.txtTitulo.Text = "Titulo do Livro:";
            // 
            // lblBordaNome
            // 
            this.lblBordaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaNome.Location = new System.Drawing.Point(135, 77);
            this.lblBordaNome.Name = "lblBordaNome";
            this.lblBordaNome.Size = new System.Drawing.Size(604, 39);
            this.lblBordaNome.TabIndex = 98;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(557, 439);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(294, 49);
            this.btnCancelar.TabIndex = 109;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cdpDataEntrega
            // 
            this.cdpDataEntrega.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cdpDataEntrega.BorderSize = 0;
            this.cdpDataEntrega.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdpDataEntrega.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.cdpDataEntrega.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.cdpDataEntrega.CalendarTitleBackColor = System.Drawing.Color.Coral;
            this.cdpDataEntrega.CalendarTitleForeColor = System.Drawing.Color.Peru;
            this.cdpDataEntrega.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.cdpDataEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cdpDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cdpDataEntrega.Location = new System.Drawing.Point(542, 199);
            this.cdpDataEntrega.MinimumSize = new System.Drawing.Size(4, 35);
            this.cdpDataEntrega.Name = "cdpDataEntrega";
            this.cdpDataEntrega.Size = new System.Drawing.Size(179, 35);
            this.cdpDataEntrega.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.cdpDataEntrega.TabIndex = 107;
            this.cdpDataEntrega.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(25, 35);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(142, 19);
            this.lblTituloForm.TabIndex = 115;
            this.lblTituloForm.Text = "Alterar Empréstimo";
            // 
            // frmAlterarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(889, 569);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDataEntrega);
            this.Controls.Add(this.cdpDataEntrega);
            this.Controls.Add(this.btnGerenciarUsuario);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblTextISBN);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblBordaNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlterarEmprestimo";
            this.Text = "frmEditarEmprestimo";
            this.Load += new System.EventHandler(this.frmAlterarEmprestimo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmAlterarEmprestimo_Paint);
            this.pnlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataEntrega;
        private CustomComponents.CustomDatePicker cdpDataEntrega;
        private System.Windows.Forms.Button btnGerenciarUsuario;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblTextISBN;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblBordaNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvUsuarioEmprestimo;
        private System.Windows.Forms.Label lblTituloForm;
    }
}