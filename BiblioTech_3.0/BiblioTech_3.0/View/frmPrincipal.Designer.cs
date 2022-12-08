
namespace BiblioTech_3._0
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGerenciadores = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnEmprestimos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.pnlNavegador = new System.Windows.Forms.Panel();
            this.pnlMeta = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.pnlTela = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGerenciadores.SuspendLayout();
            this.pnlNavegador.SuspendLayout();
            this.pnlMeta.SuspendLayout();
            this.pnlTela.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGerenciadores
            // 
            this.pnlGerenciadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlGerenciadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.pnlGerenciadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGerenciadores.Controls.Add(this.btnHome);
            this.pnlGerenciadores.Controls.Add(this.btnEventos);
            this.pnlGerenciadores.Controls.Add(this.btnEmprestimos);
            this.pnlGerenciadores.Controls.Add(this.btnUsuarios);
            this.pnlGerenciadores.Controls.Add(this.btnLivros);
            this.pnlGerenciadores.Location = new System.Drawing.Point(4, 5);
            this.pnlGerenciadores.Name = "pnlGerenciadores";
            this.pnlGerenciadores.Size = new System.Drawing.Size(295, 743);
            this.pnlGerenciadores.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(3, 91);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(288, 177);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "BiblioTech";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.btnEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEventos.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.ForeColor = System.Drawing.Color.White;
            this.btnEventos.Location = new System.Drawing.Point(2, 555);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(288, 83);
            this.btnEventos.TabIndex = 4;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnEmprestimos
            // 
            this.btnEmprestimos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.btnEmprestimos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmprestimos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmprestimos.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimos.ForeColor = System.Drawing.Color.White;
            this.btnEmprestimos.Location = new System.Drawing.Point(3, 358);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Size = new System.Drawing.Size(288, 83);
            this.btnEmprestimos.TabIndex = 3;
            this.btnEmprestimos.Text = "Emprestimos";
            this.btnEmprestimos.UseVisualStyleBackColor = false;
            this.btnEmprestimos.Click += new System.EventHandler(this.btnEmprestimos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 662);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(288, 83);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.btnLivros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLivros.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.White;
            this.btnLivros.Location = new System.Drawing.Point(3, 457);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(288, 83);
            this.btnLivros.TabIndex = 2;
            this.btnLivros.Text = "Livros";
            this.btnLivros.UseVisualStyleBackColor = false;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // pnlNavegador
            // 
            this.pnlNavegador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNavegador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.pnlNavegador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNavegador.Controls.Add(this.pnlMeta);
            this.pnlNavegador.Controls.Add(this.btnConfiguracoes);
            this.pnlNavegador.Location = new System.Drawing.Point(304, 5);
            this.pnlNavegador.Name = "pnlNavegador";
            this.pnlNavegador.Size = new System.Drawing.Size(853, 71);
            this.pnlNavegador.TabIndex = 3;
            // 
            // pnlMeta
            // 
            this.pnlMeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.pnlMeta.Controls.Add(this.label2);
            this.pnlMeta.Location = new System.Drawing.Point(250, 17);
            this.pnlMeta.Name = "pnlMeta";
            this.pnlMeta.Size = new System.Drawing.Size(259, 43);
            this.pnlMeta.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(78, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meta";
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfiguracoes.Location = new System.Drawing.Point(708, 32);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(140, 28);
            this.btnConfiguracoes.TabIndex = 5;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            // 
            // pnlTela
            // 
            this.pnlTela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.pnlTela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTela.Controls.Add(this.label1);
            this.pnlTela.Location = new System.Drawing.Point(304, 82);
            this.pnlTela.Name = "pnlTela";
            this.pnlTela.Size = new System.Drawing.Size(853, 666);
            this.pnlTela.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(231, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "BiblioTech";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1159, 749);
            this.Controls.Add(this.pnlTela);
            this.Controls.Add(this.pnlNavegador);
            this.Controls.Add(this.pnlGerenciadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.pnlGerenciadores.ResumeLayout(false);
            this.pnlNavegador.ResumeLayout(false);
            this.pnlMeta.ResumeLayout(false);
            this.pnlMeta.PerformLayout();
            this.pnlTela.ResumeLayout(false);
            this.pnlTela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGerenciadores;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnEmprestimos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Panel pnlNavegador;
        private System.Windows.Forms.Panel pnlTela;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlMeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

