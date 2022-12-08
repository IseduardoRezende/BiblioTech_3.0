using BiblioTech_3._0.CustomComponents;
using BiblioTech_3._0.Model;
using BiblioTech_3._0.View;
using System;
using System.Windows.Forms;

namespace BiblioTech_3._0
{
    public partial class frmPrincipal : Form
    {     
        public frmPrincipal()
        {
            InitializeComponent();
            frmHome frm = new frmHome();
            frm.TopLevel = false;
            pnlTela.Controls.Add(frm);
            frm.Show();           
        }       

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlTela.Controls.Clear();
            frmHome frm = new frmHome();
            frm.TopLevel = false;
            pnlTela.Controls.Add(frm);

            lblTelaUsada.Text = "Home";

            frm.Show();
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            pnlTela.Controls.Clear();
            frmEmprestimos frm = new frmEmprestimos();
            frm.TopLevel = false;
            pnlTela.Controls.Add(frm);
            
            lblTelaUsada.Text = "Empréstimos";

            frm.Show();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            pnlTela.Controls.Clear();
            frmLivros frm = new frmLivros();
            frm.TopLevel = false;
            pnlTela.Controls.Add(frm);

            lblTelaUsada.Text = "Livros";

            frm.Show();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            pnlTela.Controls.Clear();
            frmEventos frm = new frmEventos();
            frm.TopLevel = false;
            pnlTela.Controls.Add(frm);

            lblTelaUsada.Text = "Eventos";

            frm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            pnlTela.Controls.Clear();
            frmUsuarios frm = new frmUsuarios();
            frm.TopLevel = false;
            pnlTela.Controls.Add(frm);

            lblTelaUsada.Text = "Usuários";

            frm.Show();                      
        }

        private void lklblMeta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmMeta();

            lblTelaUsada.Text = "Metas";

            frm.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }    
}