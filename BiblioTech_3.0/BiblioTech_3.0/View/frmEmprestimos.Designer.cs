
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvEmprestimo = new System.Windows.Forms.DataGridView();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.btnDevolvido = new System.Windows.Forms.Button();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvEmprestimo);
            this.panel3.Location = new System.Drawing.Point(2, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 531);
            this.panel3.TabIndex = 24;
            // 
            // dgvEmprestimo
            // 
            this.dgvEmprestimo.AllowUserToAddRows = false;
            this.dgvEmprestimo.AllowUserToDeleteRows = false;
            this.dgvEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimo.Location = new System.Drawing.Point(-1, -1);
            this.dgvEmprestimo.Name = "dgvEmprestimo";
            this.dgvEmprestimo.ReadOnly = true;
            this.dgvEmprestimo.Size = new System.Drawing.Size(849, 531);
            this.dgvEmprestimo.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelecionar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionar.Location = new System.Drawing.Point(153, 607);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(126, 49);
            this.btnSelecionar.TabIndex = 23;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            // 
            // btnRenovar
            // 
            this.btnRenovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnRenovar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenovar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRenovar.Location = new System.Drawing.Point(719, 607);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(122, 49);
            this.btnRenovar.TabIndex = 22;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.UseVisualStyleBackColor = false;
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
            // 
            // frmEmprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(853, 666);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnRenovar);
            this.Controls.Add(this.btnDevolvido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmprestimos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEmprestimos";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.Button btnDevolvido;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.DataGridView dgvEmprestimo;
    }
}