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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDesarquivar = new System.Windows.Forms.Button();
            this.pnlUsuariosArquivados = new System.Windows.Forms.Panel();
            this.dgvUsuarioArquivado = new System.Windows.Forms.DataGridView();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblArquivado = new System.Windows.Forms.Label();
            this.pnlUsuariosArquivados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioArquivado)).BeginInit();
            this.SuspendLayout();
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
            this.btnSair.TabIndex = 34;
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
            this.btnDesarquivar.TabIndex = 36;
            this.btnDesarquivar.Text = "Desarquivar";
            this.btnDesarquivar.UseVisualStyleBackColor = false;
            this.btnDesarquivar.Visible = false;
            this.btnDesarquivar.Click += new System.EventHandler(this.BtnDesarquivar_Click);
            // 
            // pnlUsuariosArquivados
            // 
            this.pnlUsuariosArquivados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(49)))));
            this.pnlUsuariosArquivados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsuariosArquivados.Controls.Add(this.dgvUsuarioArquivado);
            this.pnlUsuariosArquivados.Location = new System.Drawing.Point(2, 89);
            this.pnlUsuariosArquivados.Name = "pnlUsuariosArquivados";
            this.pnlUsuariosArquivados.Size = new System.Drawing.Size(849, 521);
            this.pnlUsuariosArquivados.TabIndex = 35;
            // 
            // dgvUsuarioArquivado
            // 
            this.dgvUsuarioArquivado.AllowUserToAddRows = false;
            this.dgvUsuarioArquivado.AllowUserToDeleteRows = false;
            this.dgvUsuarioArquivado.AllowUserToResizeColumns = false;
            this.dgvUsuarioArquivado.AllowUserToResizeRows = false;
            this.dgvUsuarioArquivado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuarioArquivado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvUsuarioArquivado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.dgvUsuarioArquivado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarioArquivado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarioArquivado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarioArquivado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioArquivado.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarioArquivado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarioArquivado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarioArquivado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsuarioArquivado.EnableHeadersVisualStyles = false;
            this.dgvUsuarioArquivado.GridColor = System.Drawing.Color.White;
            this.dgvUsuarioArquivado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvUsuarioArquivado.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarioArquivado.Name = "dgvUsuarioArquivado";
            this.dgvUsuarioArquivado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarioArquivado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarioArquivado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvUsuarioArquivado.Size = new System.Drawing.Size(847, 519);
            this.dgvUsuarioArquivado.TabIndex = 1;
            this.dgvUsuarioArquivado.DoubleClick += new System.EventHandler(this.dgvUsuarioArquivado_DoubleClick);
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
            this.btnBusca.TabIndex = 38;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.BtnBusca_Click);
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
            this.txtBusca.TabIndex = 37;
            this.txtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusca_KeyPress);
            // 
            // lblArquivado
            // 
            this.lblArquivado.AutoSize = true;
            this.lblArquivado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivado.ForeColor = System.Drawing.Color.White;
            this.lblArquivado.Location = new System.Drawing.Point(35, 632);
            this.lblArquivado.Name = "lblArquivado";
            this.lblArquivado.Size = new System.Drawing.Size(0, 20);
            this.lblArquivado.TabIndex = 39;
            // 
            // frmUsuariosArquivados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(853, 666);
            this.Controls.Add(this.lblArquivado);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDesarquivar);
            this.Controls.Add(this.pnlUsuariosArquivados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuariosArquivados";
            this.Text = "frmUsuariosArquivados";
            this.Load += new System.EventHandler(this.FrmUsuariosArquivados_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmUsuariosArquivados_Paint);
            this.pnlUsuariosArquivados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioArquivado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDesarquivar;
        private System.Windows.Forms.Panel pnlUsuariosArquivados;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblArquivado;
        private System.Windows.Forms.DataGridView dgvUsuarioArquivado;
    }
}