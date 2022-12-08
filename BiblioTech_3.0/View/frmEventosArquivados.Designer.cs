namespace BiblioTech_3._0.View
{
    partial class frmEventosArquivados
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
            this.pnlEventosArquivados = new System.Windows.Forms.Panel();
            this.dgvEventoArquivado = new System.Windows.Forms.DataGridView();
            this.lblEventoEscolhido = new System.Windows.Forms.Label();
            this.pnlEventosArquivados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventoArquivado)).BeginInit();
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
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click_1);
            // 
            // btnDesarquivar
            // 
            this.btnDesarquivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnDesarquivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesarquivar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesarquivar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesarquivar.Location = new System.Drawing.Point(746, 618);
            this.btnDesarquivar.Name = "btnDesarquivar";
            this.btnDesarquivar.Size = new System.Drawing.Size(95, 38);
            this.btnDesarquivar.TabIndex = 41;
            this.btnDesarquivar.Text = "Desarquivar";
            this.btnDesarquivar.UseVisualStyleBackColor = false;
            this.btnDesarquivar.Click += new System.EventHandler(this.btnDesarquivar_Click);
            // 
            // pnlEventosArquivados
            // 
            this.pnlEventosArquivados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(49)))));
            this.pnlEventosArquivados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventosArquivados.Controls.Add(this.dgvEventoArquivado);
            this.pnlEventosArquivados.Location = new System.Drawing.Point(2, 89);
            this.pnlEventosArquivados.Name = "pnlEventosArquivados";
            this.pnlEventosArquivados.Size = new System.Drawing.Size(843, 523);
            this.pnlEventosArquivados.TabIndex = 40;
            // 
            // dgvEventoArquivado
            // 
            this.dgvEventoArquivado.AllowUserToAddRows = false;
            this.dgvEventoArquivado.AllowUserToDeleteRows = false;
            this.dgvEventoArquivado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEventoArquivado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.dgvEventoArquivado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEventoArquivado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventoArquivado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEventoArquivado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEventoArquivado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEventoArquivado.EnableHeadersVisualStyles = false;
            this.dgvEventoArquivado.Location = new System.Drawing.Point(0, -1);
            this.dgvEventoArquivado.Name = "dgvEventoArquivado";
            this.dgvEventoArquivado.ReadOnly = true;
            this.dgvEventoArquivado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventoArquivado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEventoArquivado.RowHeadersWidth = 40;
            this.dgvEventoArquivado.Size = new System.Drawing.Size(842, 523);
            this.dgvEventoArquivado.TabIndex = 0;
            this.dgvEventoArquivado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventoArquivado_CellClick);
            // 
            // lblEventoEscolhido
            // 
            this.lblEventoEscolhido.AutoSize = true;
            this.lblEventoEscolhido.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventoEscolhido.ForeColor = System.Drawing.Color.White;
            this.lblEventoEscolhido.Location = new System.Drawing.Point(35, 627);
            this.lblEventoEscolhido.Name = "lblEventoEscolhido";
            this.lblEventoEscolhido.Size = new System.Drawing.Size(0, 19);
            this.lblEventoEscolhido.TabIndex = 44;
            // 
            // frmEventosArquivados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(853, 666);
            this.Controls.Add(this.lblEventoEscolhido);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDesarquivar);
            this.Controls.Add(this.pnlEventosArquivados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEventosArquivados";
            this.Text = "frmEventosArquivados";
            this.Load += new System.EventHandler(this.frmEventosArquivados_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmEventosArquivados_Paint);
            this.pnlEventosArquivados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventoArquivado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDesarquivar;
        private System.Windows.Forms.Panel pnlEventosArquivados;
        private System.Windows.Forms.DataGridView dgvEventoArquivado;
        private System.Windows.Forms.Label lblEventoEscolhido;
    }
}