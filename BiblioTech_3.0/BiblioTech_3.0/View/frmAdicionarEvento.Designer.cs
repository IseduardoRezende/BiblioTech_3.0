
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEvento = new System.Windows.Forms.DateTimePicker();
            this.txtParticipantes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nome:";
            // 
            // txtTema
            // 
            this.txtTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtTema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTema.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtTema.Location = new System.Drawing.Point(128, 76);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(326, 33);
            this.txtTema.TabIndex = 42;
            this.txtTema.Text = "nome do evento:";
            this.txtTema.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtTema.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(363, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 49);
            this.button1.TabIndex = 41;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(89)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.Location = new System.Drawing.Point(26, 441);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(204, 49);
            this.btnAdicionar.TabIndex = 40;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Participantes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(124, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Data";
            // 
            // dtpEvento
            // 
            this.dtpEvento.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEvento.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.dtpEvento.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dtpEvento.CalendarTitleBackColor = System.Drawing.Color.Coral;
            this.dtpEvento.CalendarTitleForeColor = System.Drawing.Color.AntiqueWhite;
            this.dtpEvento.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.dtpEvento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEvento.Location = new System.Drawing.Point(128, 304);
            this.dtpEvento.Name = "dtpEvento";
            this.dtpEvento.Size = new System.Drawing.Size(200, 20);
            this.dtpEvento.TabIndex = 49;
            // 
            // txtParticipantes
            // 
            this.txtParticipantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(79)))));
            this.txtParticipantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParticipantes.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticipantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
            this.txtParticipantes.Location = new System.Drawing.Point(128, 209);
            this.txtParticipantes.Name = "txtParticipantes";
            this.txtParticipantes.Size = new System.Drawing.Size(326, 33);
            this.txtParticipantes.TabIndex = 50;
            this.txtParticipantes.Text = "nome dos participantes";
            this.txtParticipantes.Enter += new System.EventHandler(this.txtParticipantes_Enter);
            this.txtParticipantes.Leave += new System.EventHandler(this.txtParticipantes_Leave);
            // 
            // frmAdicionarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(605, 542);
            this.Controls.Add(this.txtParticipantes);
            this.Controls.Add(this.dtpEvento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "frmAdicionarEvento";
            this.Text = "frmAdicionarEvento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEvento;
        private System.Windows.Forms.TextBox txtParticipantes;
    }
}