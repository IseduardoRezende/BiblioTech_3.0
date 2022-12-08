namespace BiblioTech_3._0.View
{
    partial class frmAlterarEvento
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
            this.btnAdicionarParticipantes = new System.Windows.Forms.Button();
            this.btnRemoverParticipantes = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblParticipantes = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dgvAlterarParticipante = new System.Windows.Forms.DataGridView();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.cdpEvento = new BiblioTech_3._0.CustomComponents.CustomDatePicker();
            this.lblParticipanteSelecionado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterarParticipante)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarParticipantes
            // 
            this.btnAdicionarParticipantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnAdicionarParticipantes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarParticipantes.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarParticipantes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionarParticipantes.Location = new System.Drawing.Point(248, 252);
            this.btnAdicionarParticipantes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdicionarParticipantes.Name = "btnAdicionarParticipantes";
            this.btnAdicionarParticipantes.Size = new System.Drawing.Size(175, 46);
            this.btnAdicionarParticipantes.TabIndex = 63;
            this.btnAdicionarParticipantes.Text = "Adicionar";
            this.btnAdicionarParticipantes.UseVisualStyleBackColor = false;
            this.btnAdicionarParticipantes.Click += new System.EventHandler(this.btnAdicionarParticipantes_Click);
            // 
            // btnRemoverParticipantes
            // 
            this.btnRemoverParticipantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnRemoverParticipantes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoverParticipantes.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverParticipantes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoverParticipantes.Location = new System.Drawing.Point(470, 252);
            this.btnRemoverParticipantes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRemoverParticipantes.Name = "btnRemoverParticipantes";
            this.btnRemoverParticipantes.Size = new System.Drawing.Size(175, 46);
            this.btnRemoverParticipantes.TabIndex = 62;
            this.btnRemoverParticipantes.Text = "Remover";
            this.btnRemoverParticipantes.UseVisualStyleBackColor = false;
            this.btnRemoverParticipantes.Click += new System.EventHandler(this.btnRemoverParticipantes_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(511, 36);
            this.lblData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(48, 20);
            this.lblData.TabIndex = 59;
            this.lblData.Text = "Data";
            // 
            // lblParticipantes
            // 
            this.lblParticipantes.AutoSize = true;
            this.lblParticipantes.BackColor = System.Drawing.Color.Transparent;
            this.lblParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipantes.ForeColor = System.Drawing.Color.White;
            this.lblParticipantes.Location = new System.Drawing.Point(49, 264);
            this.lblParticipantes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblParticipantes.Name = "lblParticipantes";
            this.lblParticipantes.Size = new System.Drawing.Size(119, 20);
            this.lblParticipantes.TabIndex = 58;
            this.lblParticipantes.Text = "Participantes:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(47, 38);
            this.lblNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 20);
            this.lblNome.TabIndex = 57;
            this.lblNome.Text = "Tema:";
            // 
            // txtTema
            // 
            this.txtTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtTema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTema.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtTema.Location = new System.Drawing.Point(53, 71);
            this.txtTema.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(435, 33);
            this.txtTema.TabIndex = 56;
            this.txtTema.Text = "Tema do evento:";
            this.txtTema.Enter += new System.EventHandler(this.txtTema_Enter);
            this.txtTema.Leave += new System.EventHandler(this.txtTema_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(385, 525);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(240, 44);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinalizar.Location = new System.Drawing.Point(62, 525);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(267, 44);
            this.btnFinalizar.TabIndex = 54;
            this.btnFinalizar.Text = "Alterar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(47, 151);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(178, 20);
            this.lblDescricao.TabIndex = 65;
            this.lblDescricao.Text = "Descrição do evento:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtDescricao.Location = new System.Drawing.Point(53, 182);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(435, 33);
            this.txtDescricao.TabIndex = 64;
            this.txtDescricao.Text = "Descrição do evento:";
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // dgvAlterarParticipante
            // 
            this.dgvAlterarParticipante.AllowUserToAddRows = false;
            this.dgvAlterarParticipante.AllowUserToDeleteRows = false;
            this.dgvAlterarParticipante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlterarParticipante.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.dgvAlterarParticipante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlterarParticipante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlterarParticipante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlterarParticipante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlterarParticipante.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlterarParticipante.EnableHeadersVisualStyles = false;
            this.dgvAlterarParticipante.Location = new System.Drawing.Point(78, 320);
            this.dgvAlterarParticipante.Name = "dgvAlterarParticipante";
            this.dgvAlterarParticipante.ReadOnly = true;
            this.dgvAlterarParticipante.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlterarParticipante.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlterarParticipante.RowHeadersWidth = 40;
            this.dgvAlterarParticipante.Size = new System.Drawing.Size(583, 159);
            this.dgvAlterarParticipante.TabIndex = 84;
            this.dgvAlterarParticipante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlterarParticipante_CellClick);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(315, 27);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(108, 19);
            this.lblTituloForm.TabIndex = 115;
            this.lblTituloForm.Text = "Alterar Evento";
            // 
            // cdpEvento
            // 
            this.cdpEvento.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cdpEvento.BorderSize = 0;
            this.cdpEvento.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdpEvento.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.cdpEvento.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.cdpEvento.CalendarTitleBackColor = System.Drawing.Color.Coral;
            this.cdpEvento.CalendarTitleForeColor = System.Drawing.Color.Peru;
            this.cdpEvento.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.cdpEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cdpEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdpEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cdpEvento.Location = new System.Drawing.Point(515, 68);
            this.cdpEvento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cdpEvento.MinimumSize = new System.Drawing.Size(4, 35);
            this.cdpEvento.Name = "cdpEvento";
            this.cdpEvento.Size = new System.Drawing.Size(209, 35);
            this.cdpEvento.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.cdpEvento.TabIndex = 60;
            this.cdpEvento.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            // 
            // lblParticipanteSelecionado
            // 
            this.lblParticipanteSelecionado.AutoSize = true;
            this.lblParticipanteSelecionado.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipanteSelecionado.ForeColor = System.Drawing.Color.White;
            this.lblParticipanteSelecionado.Location = new System.Drawing.Point(74, 491);
            this.lblParticipanteSelecionado.Name = "lblParticipanteSelecionado";
            this.lblParticipanteSelecionado.Size = new System.Drawing.Size(0, 19);
            this.lblParticipanteSelecionado.TabIndex = 116;
            // 
            // frmAlterarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(742, 582);
            this.Controls.Add(this.lblParticipanteSelecionado);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.dgvAlterarParticipante);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnAdicionarParticipantes);
            this.Controls.Add(this.btnRemoverParticipantes);
            this.Controls.Add(this.cdpEvento);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblParticipantes);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmAlterarEvento";
            this.Text = "frmAlterarEvento";
            this.Load += new System.EventHandler(this.frmAlterarEvento_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmAlterarEvento_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterarParticipante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarParticipantes;
        private System.Windows.Forms.Button btnRemoverParticipantes;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblParticipantes;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblDescricao;
        public System.Windows.Forms.TextBox txtTema;
        public CustomComponents.CustomDatePicker cdpEvento;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView dgvAlterarParticipante;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label lblParticipanteSelecionado;
    }
}