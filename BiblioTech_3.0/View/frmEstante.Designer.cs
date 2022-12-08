namespace BiblioTech_3._0.View
{
    partial class frmEstante
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
            this.btnAdicionarMaior = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAdicionarMenor = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdicionarMaior
            // 
            this.btnAdicionarMaior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnAdicionarMaior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarMaior.Font = new System.Drawing.Font("Candara", 58F);
            this.btnAdicionarMaior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionarMaior.Location = new System.Drawing.Point(453, 153);
            this.btnAdicionarMaior.Name = "btnAdicionarMaior";
            this.btnAdicionarMaior.Size = new System.Drawing.Size(124, 145);
            this.btnAdicionarMaior.TabIndex = 131;
            this.btnAdicionarMaior.Text = ">";
            this.btnAdicionarMaior.UseVisualStyleBackColor = false;
            this.btnAdicionarMaior.Click += new System.EventHandler(this.btnAdicionarMaior_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(337, 163);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(99, 108);
            this.lblNumero.TabIndex = 130;
            this.lblNumero.Text = "0";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(297, 112);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(169, 20);
            this.lblNome.TabIndex = 129;
            this.lblNome.Text = "Número da Estante:";
            // 
            // btnAdicionarMenor
            // 
            this.btnAdicionarMenor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnAdicionarMenor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarMenor.Font = new System.Drawing.Font("Candara", 58F);
            this.btnAdicionarMenor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionarMenor.Location = new System.Drawing.Point(195, 153);
            this.btnAdicionarMenor.Name = "btnAdicionarMenor";
            this.btnAdicionarMenor.Size = new System.Drawing.Size(124, 145);
            this.btnAdicionarMenor.TabIndex = 128;
            this.btnAdicionarMenor.Text = "<";
            this.btnAdicionarMenor.UseVisualStyleBackColor = false;
            this.btnAdicionarMenor.Click += new System.EventHandler(this.btnAdicionarMenor_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(764, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(24, 23);
            this.btnSair.TabIndex = 132;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.Location = new System.Drawing.Point(135, 357);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(497, 49);
            this.btnAdicionar.TabIndex = 133;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmEstante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAdicionarMaior);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnAdicionarMenor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstante";
            this.Text = "frmEstante";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmEstante_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarMaior;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAdicionarMenor;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionar;
    }
}