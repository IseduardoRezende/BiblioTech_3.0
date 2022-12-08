namespace BiblioTech_3._0.View
{
    partial class frmMeta
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
            this.dgvEmprestimo = new System.Windows.Forms.DataGridView();
            this.lblMeta = new System.Windows.Forms.Label();
            this.lblEmprestimo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblBordaNome = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblFimDoPrazo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterarMeta = new System.Windows.Forms.Button();
            this.lblTabelasAtuais = new System.Windows.Forms.Label();
            this.cdpFimPrazo = new BiblioTech_3._0.CustomComponents.CustomDatePicker();
            this.cdpInicioPrazo = new BiblioTech_3._0.CustomComponents.CustomDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmprestimo
            // 
            this.dgvEmprestimo.AllowUserToAddRows = false;
            this.dgvEmprestimo.AllowUserToDeleteRows = false;
            this.dgvEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmprestimo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.dgvEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmprestimo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmprestimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmprestimo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmprestimo.EnableHeadersVisualStyles = false;
            this.dgvEmprestimo.Location = new System.Drawing.Point(33, 195);
            this.dgvEmprestimo.Name = "dgvEmprestimo";
            this.dgvEmprestimo.ReadOnly = true;
            this.dgvEmprestimo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmprestimo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmprestimo.RowHeadersWidth = 50;
            this.dgvEmprestimo.Size = new System.Drawing.Size(716, 209);
            this.dgvEmprestimo.TabIndex = 66;
            // 
            // lblMeta
            // 
            this.lblMeta.AutoSize = true;
            this.lblMeta.BackColor = System.Drawing.Color.Transparent;
            this.lblMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeta.ForeColor = System.Drawing.Color.White;
            this.lblMeta.Location = new System.Drawing.Point(338, 55);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Size = new System.Drawing.Size(99, 20);
            this.lblMeta.TabIndex = 70;
            this.lblMeta.Text = "Meta atual:";
            // 
            // lblEmprestimo
            // 
            this.lblEmprestimo.AutoSize = true;
            this.lblEmprestimo.BackColor = System.Drawing.Color.Transparent;
            this.lblEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmprestimo.ForeColor = System.Drawing.Color.White;
            this.lblEmprestimo.Location = new System.Drawing.Point(68, 163);
            this.lblEmprestimo.Name = "lblEmprestimo";
            this.lblEmprestimo.Size = new System.Drawing.Size(118, 20);
            this.lblEmprestimo.TabIndex = 68;
            this.lblEmprestimo.Text = "Empréstimos:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtTitulo.Location = new System.Drawing.Point(266, 84);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(249, 33);
            this.txtTitulo.TabIndex = 67;
            this.txtTitulo.Text = "0";
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBordaNome
            // 
            this.lblBordaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.lblBordaNome.Location = new System.Drawing.Point(263, 81);
            this.lblBordaNome.Name = "lblBordaNome";
            this.lblBordaNome.Size = new System.Drawing.Size(256, 39);
            this.lblBordaNome.TabIndex = 69;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(45, 55);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(127, 20);
            this.lblData.TabIndex = 96;
            this.lblData.Text = "Inicio do prazo";
            // 
            // lblFimDoPrazo
            // 
            this.lblFimDoPrazo.AutoSize = true;
            this.lblFimDoPrazo.BackColor = System.Drawing.Color.Transparent;
            this.lblFimDoPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFimDoPrazo.ForeColor = System.Drawing.Color.White;
            this.lblFimDoPrazo.Location = new System.Drawing.Point(582, 55);
            this.lblFimDoPrazo.Name = "lblFimDoPrazo";
            this.lblFimDoPrazo.Size = new System.Drawing.Size(114, 20);
            this.lblFimDoPrazo.TabIndex = 98;
            this.lblFimDoPrazo.Text = "Fim do Prazo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(552, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 49);
            this.btnCancelar.TabIndex = 100;
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
            this.btnAdicionar.Location = new System.Drawing.Point(33, 420);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(215, 49);
            this.btnAdicionar.TabIndex = 99;
            this.btnAdicionar.Text = "Concluir Meta e Criar nova";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterarMeta
            // 
            this.btnAlterarMeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnAlterarMeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarMeta.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarMeta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterarMeta.Location = new System.Drawing.Point(311, 420);
            this.btnAlterarMeta.Name = "btnAlterarMeta";
            this.btnAlterarMeta.Size = new System.Drawing.Size(175, 49);
            this.btnAlterarMeta.TabIndex = 101;
            this.btnAlterarMeta.Text = "Alterar";
            this.btnAlterarMeta.UseVisualStyleBackColor = false;
            this.btnAlterarMeta.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTabelasAtuais
            // 
            this.lblTabelasAtuais.AutoSize = true;
            this.lblTabelasAtuais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabelasAtuais.ForeColor = System.Drawing.Color.White;
            this.lblTabelasAtuais.Location = new System.Drawing.Point(298, 163);
            this.lblTabelasAtuais.Name = "lblTabelasAtuais";
            this.lblTabelasAtuais.Size = new System.Drawing.Size(0, 20);
            this.lblTabelasAtuais.TabIndex = 102;
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
            this.cdpFimPrazo.Location = new System.Drawing.Point(570, 85);
            this.cdpFimPrazo.MinimumSize = new System.Drawing.Size(4, 35);
            this.cdpFimPrazo.Name = "cdpFimPrazo";
            this.cdpFimPrazo.Size = new System.Drawing.Size(179, 35);
            this.cdpFimPrazo.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.cdpFimPrazo.TabIndex = 97;
            this.cdpFimPrazo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            // 
            // cdpInicioPrazo
            // 
            this.cdpInicioPrazo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cdpInicioPrazo.BorderSize = 0;
            this.cdpInicioPrazo.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdpInicioPrazo.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.cdpInicioPrazo.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.cdpInicioPrazo.CalendarTitleBackColor = System.Drawing.Color.Coral;
            this.cdpInicioPrazo.CalendarTitleForeColor = System.Drawing.Color.Peru;
            this.cdpInicioPrazo.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.cdpInicioPrazo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cdpInicioPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdpInicioPrazo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cdpInicioPrazo.Location = new System.Drawing.Point(33, 85);
            this.cdpInicioPrazo.MinimumSize = new System.Drawing.Size(4, 35);
            this.cdpInicioPrazo.Name = "cdpInicioPrazo";
            this.cdpInicioPrazo.Size = new System.Drawing.Size(179, 35);
            this.cdpInicioPrazo.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.cdpInicioPrazo.TabIndex = 95;
            this.cdpInicioPrazo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            // 
            // frmMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.lblTabelasAtuais);
            this.Controls.Add(this.btnAlterarMeta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblFimDoPrazo);
            this.Controls.Add(this.cdpFimPrazo);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cdpInicioPrazo);
            this.Controls.Add(this.dgvEmprestimo);
            this.Controls.Add(this.lblMeta);
            this.Controls.Add(this.lblEmprestimo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblBordaNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMeta";
            this.Text = "Metas";
            this.Load += new System.EventHandler(this.frmMeta_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMeta_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmprestimo;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.Label lblEmprestimo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblBordaNome;
        private System.Windows.Forms.Label lblData;
        private CustomComponents.CustomDatePicker cdpInicioPrazo;
        private System.Windows.Forms.Label lblFimDoPrazo;
        private CustomComponents.CustomDatePicker cdpFimPrazo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterarMeta;
        private System.Windows.Forms.Label lblTabelasAtuais;
    }
}