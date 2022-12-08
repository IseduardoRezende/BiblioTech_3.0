
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
            this.btnEventos = new System.Windows.Forms.Button();
            this.pnlMeta = new System.Windows.Forms.Panel();
            this.lklblMeta = new System.Windows.Forms.LinkLabel();
            this.btnEmprestimos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlNavegador = new System.Windows.Forms.Panel();
            this.lblTelaUsada = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnTelaCheia = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlTela = new System.Windows.Forms.Panel();
            this.pnlGerenciadores.SuspendLayout();
            this.pnlMeta.SuspendLayout();
            this.pnlNavegador.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGerenciadores
            // 
            this.pnlGerenciadores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGerenciadores.AutoScroll = true;
            this.pnlGerenciadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.pnlGerenciadores.Controls.Add(this.btnEventos);
            this.pnlGerenciadores.Controls.Add(this.pnlMeta);
            this.pnlGerenciadores.Controls.Add(this.btnEmprestimos);
            this.pnlGerenciadores.Controls.Add(this.btnUsuarios);
            this.pnlGerenciadores.Controls.Add(this.btnLivros);
            this.pnlGerenciadores.Controls.Add(this.btnHome);
            this.pnlGerenciadores.Location = new System.Drawing.Point(0, 0);
            this.pnlGerenciadores.Name = "pnlGerenciadores";
            this.pnlGerenciadores.Size = new System.Drawing.Size(304, 745);
            this.pnlGerenciadores.TabIndex = 1;
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.btnEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEventos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.ForeColor = System.Drawing.Color.White;
            this.btnEventos.Location = new System.Drawing.Point(0, 332);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(304, 83);
            this.btnEventos.TabIndex = 4;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // pnlMeta
            // 
            this.pnlMeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.pnlMeta.Controls.Add(this.lklblMeta);
            this.pnlMeta.Location = new System.Drawing.Point(26, 421);
            this.pnlMeta.Name = "pnlMeta";
            this.pnlMeta.Size = new System.Drawing.Size(260, 107);
            this.pnlMeta.TabIndex = 7;
            // 
            // lklblMeta
            // 
            this.lklblMeta.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(48)))));
            this.lklblMeta.AutoSize = true;
            this.lklblMeta.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblMeta.ForeColor = System.Drawing.Color.White;
            this.lklblMeta.LinkColor = System.Drawing.Color.White;
            this.lklblMeta.Location = new System.Drawing.Point(74, 33);
            this.lklblMeta.Name = "lklblMeta";
            this.lklblMeta.Size = new System.Drawing.Size(101, 38);
            this.lklblMeta.TabIndex = 3;
            this.lklblMeta.TabStop = true;
            this.lklblMeta.Text = "Metas";
            this.lklblMeta.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(49)))));
            this.lklblMeta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblMeta_LinkClicked);
            // 
            // btnEmprestimos
            // 
            this.btnEmprestimos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.btnEmprestimos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmprestimos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmprestimos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.btnEmprestimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimos.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimos.ForeColor = System.Drawing.Color.White;
            this.btnEmprestimos.Location = new System.Drawing.Point(0, 249);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Size = new System.Drawing.Size(304, 83);
            this.btnEmprestimos.TabIndex = 3;
            this.btnEmprestimos.Text = "Empréstimos";
            this.btnEmprestimos.UseVisualStyleBackColor = false;
            this.btnEmprestimos.Click += new System.EventHandler(this.btnEmprestimos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 166);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(304, 83);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.btnLivros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLivros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.White;
            this.btnLivros.Location = new System.Drawing.Point(0, 83);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(304, 83);
            this.btnLivros.TabIndex = 2;
            this.btnLivros.Text = "Livros";
            this.btnLivros.UseVisualStyleBackColor = false;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(304, 83);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "BiblioTech";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlNavegador
            // 
            this.pnlNavegador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlNavegador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(71)))));
            this.pnlNavegador.Controls.Add(this.lblTelaUsada);
            this.pnlNavegador.Controls.Add(this.btnMinimizar);
            this.pnlNavegador.Controls.Add(this.btnTelaCheia);
            this.pnlNavegador.Controls.Add(this.btnSair);
            this.pnlNavegador.Location = new System.Drawing.Point(304, 0);
            this.pnlNavegador.Name = "pnlNavegador";
            this.pnlNavegador.Size = new System.Drawing.Size(853, 82);
            this.pnlNavegador.TabIndex = 3;
            // 
            // lblTelaUsada
            // 
            this.lblTelaUsada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelaUsada.AutoSize = true;
            this.lblTelaUsada.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelaUsada.ForeColor = System.Drawing.Color.White;
            this.lblTelaUsada.Location = new System.Drawing.Point(23, 28);
            this.lblTelaUsada.Name = "lblTelaUsada";
            this.lblTelaUsada.Size = new System.Drawing.Size(93, 35);
            this.lblTelaUsada.TabIndex = 8;
            this.lblTelaUsada.Text = "Home";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(774, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(37, 30);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "--";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnTelaCheia
            // 
            this.btnTelaCheia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTelaCheia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTelaCheia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTelaCheia.Location = new System.Drawing.Point(712, 3);
            this.btnTelaCheia.Name = "btnTelaCheia";
            this.btnTelaCheia.Size = new System.Drawing.Size(24, 23);
            this.btnTelaCheia.TabIndex = 1;
            this.btnTelaCheia.Text = "=";
            this.btnTelaCheia.UseVisualStyleBackColor = true;
            this.btnTelaCheia.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(71)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(817, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(33, 30);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlTela
            // 
            this.pnlTela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.pnlTela.Location = new System.Drawing.Point(304, 82);
            this.pnlTela.Name = "pnlTela";
            this.pnlTela.Size = new System.Drawing.Size(853, 666);
            this.pnlTela.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1157, 746);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTela);
            this.Controls.Add(this.pnlNavegador);
            this.Controls.Add(this.pnlGerenciadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlGerenciadores.ResumeLayout(false);
            this.pnlMeta.ResumeLayout(false);
            this.pnlMeta.PerformLayout();
            this.pnlNavegador.ResumeLayout(false);
            this.pnlNavegador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGerenciadores;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnEmprestimos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Panel pnlNavegador;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlMeta;
        private System.Windows.Forms.Label lblTelaUsada;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnTelaCheia;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Panel pnlTela;
        private System.Windows.Forms.LinkLabel lklblMeta;
    }
}

