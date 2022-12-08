namespace BiblioTech_3._0.View
{
    partial class frmUsuariosArquivados
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
            this.dgvUsuarioArquivado = new System.Windows.Forms.DataGridView();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnDesarquivar = new System.Windows.Forms.Button();
            this.lblEscolha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioArquivado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarioArquivado
            // 
            this.dgvUsuarioArquivado.AllowUserToAddRows = false;
            this.dgvUsuarioArquivado.AllowUserToDeleteRows = false;
            this.dgvUsuarioArquivado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioArquivado.Location = new System.Drawing.Point(12, 96);
            this.dgvUsuarioArquivado.Name = "dgvUsuarioArquivado";
            this.dgvUsuarioArquivado.ReadOnly = true;
            this.dgvUsuarioArquivado.Size = new System.Drawing.Size(753, 366);
            this.dgvUsuarioArquivado.TabIndex = 0;
            this.dgvUsuarioArquivado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarioArquivado_CellDoubleClick);
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusca.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBusca.Location = new System.Drawing.Point(637, 23);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(91, 49);
            this.btnBusca.TabIndex = 20;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusca.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(103, 32);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(509, 40);
            this.txtBusca.TabIndex = 19;
            this.txtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusca_KeyPress);
            // 
            // btnDesarquivar
            // 
            this.btnDesarquivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesarquivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesarquivar.ForeColor = System.Drawing.Color.White;
            this.btnDesarquivar.Location = new System.Drawing.Point(655, 468);
            this.btnDesarquivar.Name = "btnDesarquivar";
            this.btnDesarquivar.Size = new System.Drawing.Size(110, 35);
            this.btnDesarquivar.TabIndex = 21;
            this.btnDesarquivar.Text = "Desarquivar";
            this.btnDesarquivar.UseVisualStyleBackColor = true;
            this.btnDesarquivar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.ForeColor = System.Drawing.Color.White;
            this.lblEscolha.Location = new System.Drawing.Point(12, 471);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(0, 16);
            this.lblEscolha.TabIndex = 22;
            // 
            // frmUsuariosArquivados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(786, 509);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.btnDesarquivar);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvUsuarioArquivado);
            this.Name = "frmUsuariosArquivados";
            this.Text = "Arquivados";
            this.Load += new System.EventHandler(this.frmUsuariosArquivados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioArquivado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarioArquivado;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnDesarquivar;
        private System.Windows.Forms.Label lblEscolha;
    }
}