
namespace BiblioTech_3._0
{
    partial class frmHome
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlMeta = new System.Windows.Forms.Panel();
            this.lklblMeta = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTitulo.Location = new System.Drawing.Point(231, 217);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(342, 73);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "BiblioTech";
            // 
            // pnlMeta
            // 
            this.pnlMeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.pnlMeta.Controls.Add(this.label1);
            this.pnlMeta.Location = new System.Drawing.Point(265, 293);
            this.pnlMeta.Name = "pnlMeta";
            this.pnlMeta.Size = new System.Drawing.Size(259, 57);
            this.pnlMeta.TabIndex = 8;
            // 
            // lklblMeta
            // 
            this.lklblMeta.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(48)))));
            this.lklblMeta.AutoSize = true;
            this.lklblMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblMeta.ForeColor = System.Drawing.Color.White;
            this.lklblMeta.LinkColor = System.Drawing.Color.White;
            this.lklblMeta.Location = new System.Drawing.Point(686, 561);
            this.lklblMeta.Name = "lklblMeta";
            this.lklblMeta.Size = new System.Drawing.Size(98, 39);
            this.lklblMeta.TabIndex = 4;
            this.lklblMeta.TabStop = true;
            this.lklblMeta.Text = "Meta";
            this.lklblMeta.Visible = false;
            this.lklblMeta.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(49)))));
            this.lklblMeta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblMeta_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-vindo";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(837, 627);
            this.Controls.Add(this.lklblMeta);
            this.Controls.Add(this.pnlMeta);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.pnlMeta.ResumeLayout(false);
            this.pnlMeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlMeta;
        private System.Windows.Forms.LinkLabel lklblMeta;
        private System.Windows.Forms.Label label1;
    }
}