namespace BiblioTech_3._0.View
{
    partial class frmAdicionarMeta
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblFimDePrazo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblAutores = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblBordaNome = new System.Windows.Forms.Label();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.cdpFimPrazo = new BiblioTech_3._0.CustomComponents.CustomDatePicker();
            this.cdpDataInicio = new BiblioTech_3._0.CustomComponents.CustomDatePicker();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(517, 379);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 49);
            this.btnCancelar.TabIndex = 111;
            this.btnCancelar.Text = "Sair";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.Location = new System.Drawing.Point(81, 379);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(290, 49);
            this.btnAdicionar.TabIndex = 110;
            this.btnAdicionar.Text = "Adicionar Meta";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblFimDePrazo
            // 
            this.lblFimDePrazo.AutoSize = true;
            this.lblFimDePrazo.BackColor = System.Drawing.Color.Transparent;
            this.lblFimDePrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFimDePrazo.ForeColor = System.Drawing.Color.White;
            this.lblFimDePrazo.Location = new System.Drawing.Point(334, 234);
            this.lblFimDePrazo.Name = "lblFimDePrazo";
            this.lblFimDePrazo.Size = new System.Drawing.Size(114, 20);
            this.lblFimDePrazo.TabIndex = 109;
            this.lblFimDePrazo.Text = "Fim do Prazo";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(334, 124);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(127, 20);
            this.lblData.TabIndex = 107;
            this.lblData.Text = "Inicio do prazo";
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.BackColor = System.Drawing.Color.Transparent;
            this.lblAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutores.ForeColor = System.Drawing.Color.White;
            this.lblAutores.Location = new System.Drawing.Point(349, 22);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(99, 20);
            this.lblAutores.TabIndex = 105;
            this.lblAutores.Text = "Meta atual:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtTitulo.Location = new System.Drawing.Point(275, 58);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(249, 33);
            this.txtTitulo.TabIndex = 102;
            this.txtTitulo.Text = "0";
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitulo.Enter += new System.EventHandler(this.txtTitulo_Enter);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // lblBordaNome
            // 
            this.lblBordaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaNome.Location = new System.Drawing.Point(272, 55);
            this.lblBordaNome.Name = "lblBordaNome";
            this.lblBordaNome.Size = new System.Drawing.Size(256, 39);
            this.lblBordaNome.TabIndex = 104;
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(33, 23);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(133, 19);
            this.lblTituloForm.TabIndex = 115;
            this.lblTituloForm.Text = "Cadastro de  Meta";
            // 
            // cdpFimPrazo
            // 
            this.cdpFimPrazo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cdpFimPrazo.BorderSize = 0;
            this.cdpFimPrazo.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdpFimPrazo.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.cdpFimPrazo.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.cdpFimPrazo.CalendarTitleBackColor = System.Drawing.Color.Coral;
            this.cdpFimPrazo.CalendarTitleForeColor = System.Drawing.Color.Peru;
            this.cdpFimPrazo.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.cdpFimPrazo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cdpFimPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdpFimPrazo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cdpFimPrazo.Location = new System.Drawing.Point(322, 264);
            this.cdpFimPrazo.MinimumSize = new System.Drawing.Size(4, 35);
            this.cdpFimPrazo.Name = "cdpFimPrazo";
            this.cdpFimPrazo.Size = new System.Drawing.Size(179, 35);
            this.cdpFimPrazo.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.cdpFimPrazo.TabIndex = 108;
            this.cdpFimPrazo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            // 
            // cdpDataInicio
            // 
            this.cdpDataInicio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cdpDataInicio.BorderSize = 0;
            this.cdpDataInicio.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdpDataInicio.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.cdpDataInicio.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.cdpDataInicio.CalendarTitleBackColor = System.Drawing.Color.Coral;
            this.cdpDataInicio.CalendarTitleForeColor = System.Drawing.Color.Peru;
            this.cdpDataInicio.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.cdpDataInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cdpDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cdpDataInicio.Location = new System.Drawing.Point(322, 154);
            this.cdpDataInicio.MinimumSize = new System.Drawing.Size(4, 35);
            this.cdpDataInicio.Name = "cdpDataInicio";
            this.cdpDataInicio.Size = new System.Drawing.Size(179, 35);
            this.cdpDataInicio.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.cdpDataInicio.TabIndex = 106;
            this.cdpDataInicio.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            // 
            // frmAdicionarMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblFimDePrazo);
            this.Controls.Add(this.cdpFimPrazo);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cdpDataInicio);
            this.Controls.Add(this.lblAutores);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblBordaNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdicionarMeta";
            this.Text = "frmAdicionarMeta";
            this.Load += new System.EventHandler(this.frmAdicionarMeta_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmAdicionarMeta_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblFimDePrazo;
        private CustomComponents.CustomDatePicker cdpFimPrazo;
        private System.Windows.Forms.Label lblData;
        private CustomComponents.CustomDatePicker cdpDataInicio;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblBordaNome;
        private System.Windows.Forms.Label lblTituloForm;
    }
}