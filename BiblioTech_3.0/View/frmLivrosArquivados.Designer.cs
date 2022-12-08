namespace BiblioTech_3._0.View
{
    partial class frmLivrosArquivados
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
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDesarquivar = new System.Windows.Forms.Button();
            this.pnlLivroArquivado = new System.Windows.Forms.Panel();
            this.dgvLivrosArquivados = new System.Windows.Forms.DataGridView();
            this.lblLivroSelecionado = new System.Windows.Forms.Label();
            this.pnlLivroArquivado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosArquivados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusca.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBusca.Location = new System.Drawing.Point(695, 20);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(82, 49);
            this.btnBusca.TabIndex = 43;
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
            this.txtBusca.Location = new System.Drawing.Point(112, 29);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(577, 40);
            this.txtBusca.TabIndex = 42;
            this.txtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusca_KeyPress);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(821, 9);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(24, 23);
            this.btnSair.TabIndex = 39;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnDesarquivar
            // 
            this.btnDesarquivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnDesarquivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesarquivar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesarquivar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesarquivar.Location = new System.Drawing.Point(750, 619);
            this.btnDesarquivar.Name = "btnDesarquivar";
            this.btnDesarquivar.Size = new System.Drawing.Size(95, 38);
            this.btnDesarquivar.TabIndex = 41;
            this.btnDesarquivar.Text = "Desarquivar";
            this.btnDesarquivar.UseVisualStyleBackColor = false;
            this.btnDesarquivar.Click += new System.EventHandler(this.btnDesarquivar_Click);
            // 
            // pnlLivroArquivado
            // 
            this.pnlLivroArquivado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(49)))));
            this.pnlLivroArquivado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLivroArquivado.Controls.Add(this.dgvLivrosArquivados);
            this.pnlLivroArquivado.Location = new System.Drawing.Point(2, 89);
            this.pnlLivroArquivado.Name = "pnlLivroArquivado";
            this.pnlLivroArquivado.Size = new System.Drawing.Size(849, 521);
            this.pnlLivroArquivado.TabIndex = 40;
            // 
            // dgvLivrosArquivados
            // 
            this.dgvLivrosArquivados.AllowUserToAddRows = false;
            this.dgvLivrosArquivados.AllowUserToDeleteRows = false;
            this.dgvLivrosArquivados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLivrosArquivados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.dgvLivrosArquivados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLivrosArquivados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivrosArquivados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivrosArquivados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLivrosArquivados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLivrosArquivados.EnableHeadersVisualStyles = false;
            this.dgvLivrosArquivados.Location = new System.Drawing.Point(0, 0);
            this.dgvLivrosArquivados.Name = "dgvLivrosArquivados";
            this.dgvLivrosArquivados.ReadOnly = true;
            this.dgvLivrosArquivados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivrosArquivados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLivrosArquivados.RowHeadersWidth = 40;
            this.dgvLivrosArquivados.Size = new System.Drawing.Size(847, 519);
            this.dgvLivrosArquivados.TabIndex = 0;
            this.dgvLivrosArquivados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivrosArquivados_CellClick);
            // 
            // lblLivroSelecionado
            // 
            this.lblLivroSelecionado.AutoSize = true;
            this.lblLivroSelecionado.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivroSelecionado.ForeColor = System.Drawing.Color.White;
            this.lblLivroSelecionado.Location = new System.Drawing.Point(23, 628);
            this.lblLivroSelecionado.Name = "lblLivroSelecionado";
            this.lblLivroSelecionado.Size = new System.Drawing.Size(0, 19);
            this.lblLivroSelecionado.TabIndex = 44;
            // 
            // frmLivrosArquivados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(853, 666);
            this.Controls.Add(this.lblLivroSelecionado);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDesarquivar);
            this.Controls.Add(this.pnlLivroArquivado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLivrosArquivados";
            this.Text = "frmLivrosArquivados";
            this.Load += new System.EventHandler(this.frmLivrosArquivados_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmLivrosArquivados_Paint);
            this.pnlLivroArquivado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosArquivados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDesarquivar;
        private System.Windows.Forms.Panel pnlLivroArquivado;
        private System.Windows.Forms.DataGridView dgvLivrosArquivados;
        private System.Windows.Forms.Label lblLivroSelecionado;
    }
}