namespace BiblioTech_3._0.View
{
    partial class frmAlterarParticipante
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
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.btnAdicionarParticipante = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.pnlAddParticipante = new System.Windows.Forms.Panel();
            this.dgvAddParticipantes = new System.Windows.Forms.DataGridView();
            this.lblParticipanteEscolhido = new System.Windows.Forms.Label();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlAddParticipante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(218, 22);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(177, 19);
            this.lblTituloForm.TabIndex = 122;
            this.lblTituloForm.Text = "Adicionar Participante(s)";
            // 
            // btnAdicionarParticipante
            // 
            this.btnAdicionarParticipante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnAdicionarParticipante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarParticipante.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarParticipante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionarParticipante.Location = new System.Drawing.Point(168, 601);
            this.btnAdicionarParticipante.Name = "btnAdicionarParticipante";
            this.btnAdicionarParticipante.Size = new System.Drawing.Size(122, 37);
            this.btnAdicionarParticipante.TabIndex = 121;
            this.btnAdicionarParticipante.Text = "Adicionar";
            this.btnAdicionarParticipante.UseVisualStyleBackColor = false;
            this.btnAdicionarParticipante.Click += new System.EventHandler(this.btnAdicionarParticipante_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusca.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBusca.Location = new System.Drawing.Point(487, 45);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(82, 49);
            this.btnBusca.TabIndex = 118;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusca.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.Color.White;
            this.txtBusca.Location = new System.Drawing.Point(60, 54);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(403, 40);
            this.txtBusca.TabIndex = 117;
            this.txtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusca_KeyPress);
            // 
            // pnlAddParticipante
            // 
            this.pnlAddParticipante.Controls.Add(this.dgvAddParticipantes);
            this.pnlAddParticipante.Location = new System.Drawing.Point(12, 116);
            this.pnlAddParticipante.Name = "pnlAddParticipante";
            this.pnlAddParticipante.Size = new System.Drawing.Size(576, 442);
            this.pnlAddParticipante.TabIndex = 116;
            // 
            // dgvAddParticipantes
            // 
            this.dgvAddParticipantes.AllowUserToAddRows = false;
            this.dgvAddParticipantes.AllowUserToDeleteRows = false;
            this.dgvAddParticipantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddParticipantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.dgvAddParticipantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddParticipantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddParticipantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddParticipantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddParticipantes.EnableHeadersVisualStyles = false;
            this.dgvAddParticipantes.Location = new System.Drawing.Point(3, 0);
            this.dgvAddParticipantes.Name = "dgvAddParticipantes";
            this.dgvAddParticipantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddParticipantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddParticipantes.RowHeadersWidth = 70;
            this.dgvAddParticipantes.Size = new System.Drawing.Size(573, 440);
            this.dgvAddParticipantes.TabIndex = 2;
            this.dgvAddParticipantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddParticipantes_CellClick);
            // 
            // lblParticipanteEscolhido
            // 
            this.lblParticipanteEscolhido.AutoSize = true;
            this.lblParticipanteEscolhido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipanteEscolhido.ForeColor = System.Drawing.Color.White;
            this.lblParticipanteEscolhido.Location = new System.Drawing.Point(12, 574);
            this.lblParticipanteEscolhido.Name = "lblParticipanteEscolhido";
            this.lblParticipanteEscolhido.Size = new System.Drawing.Size(0, 20);
            this.lblParticipanteEscolhido.TabIndex = 124;
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConcluir.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConcluir.Location = new System.Drawing.Point(330, 601);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(122, 37);
            this.btnConcluir.TabIndex = 125;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(557, 6);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(32, 32);
            this.btnSair.TabIndex = 126;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmAlterarParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(603, 650);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.lblParticipanteEscolhido);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.btnAdicionarParticipante);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.pnlAddParticipante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlterarParticipante";
            this.Load += new System.EventHandler(this.frmAlterarParticipante_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmAlterarParticipante_Paint);
            this.pnlAddParticipante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Button btnAdicionarParticipante;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Panel pnlAddParticipante;
        private System.Windows.Forms.DataGridView dgvAddParticipantes;
        private System.Windows.Forms.Label lblParticipanteEscolhido;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnSair;
    }
}