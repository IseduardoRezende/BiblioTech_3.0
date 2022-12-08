
using BiblioTech_3._0.CustomComponents;

namespace BiblioTech_3._0
{
    partial class frmAdicionarEvento
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
            this.txtTema = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dgvAdicionarParticipantes = new System.Windows.Forms.DataGridView();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.lblTextParticipantes = new System.Windows.Forms.Label();
            this.pnlParticipantes = new System.Windows.Forms.Panel();
            this.cdpEvento = new BiblioTech_3._0.CustomComponents.CustomDatePicker();
            this.lblTituloForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionarParticipantes)).BeginInit();
            this.pnlParticipantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(57, 158);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 20);
            this.lblNome.TabIndex = 45;
            this.lblNome.Text = "Tema:";
            // 
            // txtTema
            // 
            this.txtTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtTema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTema.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtTema.Location = new System.Drawing.Point(63, 190);
            this.txtTema.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(434, 33);
            this.txtTema.TabIndex = 42;
            this.txtTema.Text = "Tema do evento:";
            this.txtTema.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtTema.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(394, 480);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(236, 51);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.Location = new System.Drawing.Point(101, 480);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(230, 51);
            this.btnAdicionar.TabIndex = 40;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(543, 61);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(48, 20);
            this.lblData.TabIndex = 48;
            this.lblData.Text = "Data";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(57, 61);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(144, 20);
            this.lblDescricao.TabIndex = 56;
            this.lblDescricao.Text = "Título do Evento:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtDescricao.Location = new System.Drawing.Point(63, 92);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(434, 33);
            this.txtDescricao.TabIndex = 55;
            this.txtDescricao.Text = "Título do Evento:";
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // dgvAdicionarParticipantes
            // 
            this.dgvAdicionarParticipantes.AllowUserToAddRows = false;
            this.dgvAdicionarParticipantes.AllowUserToDeleteRows = false;
            this.dgvAdicionarParticipantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdicionarParticipantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.dgvAdicionarParticipantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdicionarParticipantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdicionarParticipantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdicionarParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdicionarParticipantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdicionarParticipantes.EnableHeadersVisualStyles = false;
            this.dgvAdicionarParticipantes.Location = new System.Drawing.Point(0, 0);
            this.dgvAdicionarParticipantes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvAdicionarParticipantes.Name = "dgvAdicionarParticipantes";
            this.dgvAdicionarParticipantes.ReadOnly = true;
            this.dgvAdicionarParticipantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdicionarParticipantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdicionarParticipantes.RowHeadersWidth = 40;
            this.dgvAdicionarParticipantes.Size = new System.Drawing.Size(620, 137);
            this.dgvAdicionarParticipantes.TabIndex = 84;
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerenciar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerenciar.Location = new System.Drawing.Point(514, 249);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(167, 41);
            this.btnGerenciar.TabIndex = 93;
            this.btnGerenciar.Text = "Gerenciar";
            this.btnGerenciar.UseVisualStyleBackColor = false;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // lblTextParticipantes
            // 
            this.lblTextParticipantes.AutoSize = true;
            this.lblTextParticipantes.BackColor = System.Drawing.Color.Transparent;
            this.lblTextParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextParticipantes.ForeColor = System.Drawing.Color.White;
            this.lblTextParticipantes.Location = new System.Drawing.Point(59, 258);
            this.lblTextParticipantes.Name = "lblTextParticipantes";
            this.lblTextParticipantes.Size = new System.Drawing.Size(119, 20);
            this.lblTextParticipantes.TabIndex = 94;
            this.lblTextParticipantes.Text = "Participantes:";
            // 
            // pnlParticipantes
            // 
            this.pnlParticipantes.Controls.Add(this.dgvAdicionarParticipantes);
            this.pnlParticipantes.Location = new System.Drawing.Point(61, 312);
            this.pnlParticipantes.Name = "pnlParticipantes";
            this.pnlParticipantes.Size = new System.Drawing.Size(620, 137);
            this.pnlParticipantes.TabIndex = 95;
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
            this.cdpEvento.Location = new System.Drawing.Point(547, 92);
            this.cdpEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cdpEvento.MinimumSize = new System.Drawing.Size(4, 35);
            this.cdpEvento.Name = "cdpEvento";
            this.cdpEvento.Size = new System.Drawing.Size(210, 35);
            this.cdpEvento.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.cdpEvento.TabIndex = 49;
            this.cdpEvento.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(325, 39);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(145, 19);
            this.lblTituloForm.TabIndex = 115;
            this.lblTituloForm.Text = "Cadastro de  Evento";
            // 
            // frmAdicionarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(766, 562);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.pnlParticipantes);
            this.Controls.Add(this.lblTextParticipantes);
            this.Controls.Add(this.btnGerenciar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cdpEvento);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdicionarEvento";
            this.Text = "frmAdicionarEvento";
            this.Load += new System.EventHandler(this.frmAdicionarEvento_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmAdicionarEvento_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionarParticipantes)).EndInit();
            this.pnlParticipantes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblData;
        private CustomDatePicker cdpEvento;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.Label lblTextParticipantes;
        private System.Windows.Forms.Panel pnlParticipantes;
        public System.Windows.Forms.DataGridView dgvAdicionarParticipantes;
        private System.Windows.Forms.Label lblTituloForm;
    }
}