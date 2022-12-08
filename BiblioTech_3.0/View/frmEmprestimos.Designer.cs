
namespace BiblioTech_3._0
{
    partial class frmEmprestimos
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
            this.pnlEmprestimo = new System.Windows.Forms.Panel();
            this.dgvEmprestimo = new System.Windows.Forms.DataGridView();
            this.btnDevolvido = new System.Windows.Forms.Button();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.pnlEmprestimo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmprestimo
            // 
            this.pnlEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.pnlEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmprestimo.Controls.Add(this.dgvEmprestimo);
            this.pnlEmprestimo.Location = new System.Drawing.Point(2, 66);
            this.pnlEmprestimo.Name = "pnlEmprestimo";
            this.pnlEmprestimo.Size = new System.Drawing.Size(849, 531);
            this.pnlEmprestimo.TabIndex = 24;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmprestimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmprestimo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmprestimo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmprestimo.EnableHeadersVisualStyles = false;
            this.dgvEmprestimo.Location = new System.Drawing.Point(0, 1);
            this.dgvEmprestimo.Name = "dgvEmprestimo";
            this.dgvEmprestimo.ReadOnly = true;
            this.dgvEmprestimo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmprestimo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmprestimo.RowHeadersWidth = 70;
            this.dgvEmprestimo.Size = new System.Drawing.Size(848, 529);
            this.dgvEmprestimo.TabIndex = 1;
            this.dgvEmprestimo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmprestimo_CellClick);
            this.dgvEmprestimo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmprestimo_CellDoubleClick);
            // 
            // btnDevolvido
            // 
            this.btnDevolvido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnDevolvido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevolvido.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolvido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDevolvido.Location = new System.Drawing.Point(12, 607);
            this.btnDevolvido.Name = "btnDevolvido";
            this.btnDevolvido.Size = new System.Drawing.Size(126, 49);
            this.btnDevolvido.TabIndex = 20;
            this.btnDevolvido.Text = "Devolvido";
            this.btnDevolvido.UseVisualStyleBackColor = false;
            this.btnDevolvido.Click += new System.EventHandler(this.btnDevolvido_Click);
            // 
            // btnArquivo
            // 
            this.btnArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArquivo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnArquivo.Location = new System.Drawing.Point(746, 12);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(95, 38);
            this.btnArquivo.TabIndex = 25;
            this.btnArquivo.Text = "Arquivo";
            this.btnArquivo.UseVisualStyleBackColor = false;
            this.btnArquivo.Click += new System.EventHandler(this.BtnArquivo_Click);
            // 
            // frmEmprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(853, 666);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.pnlEmprestimo);
            this.Controls.Add(this.btnDevolvido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmprestimos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEmprestimos";
            this.Load += new System.EventHandler(this.frmEmprestimos_Load);
            this.pnlEmprestimo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmprestimo;
        private System.Windows.Forms.Button btnDevolvido;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.DataGridView dgvEmprestimo;
    }
}