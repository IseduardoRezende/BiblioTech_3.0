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
            frm.Show();
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            pnlTela.Controls.Clear();
            frmEmprestimos frm = new frmEmprestimos();
            frm.TopLevel = false;
            pnlTela.Controls.Add(frm);
            frm.Show();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            pnlTela.Controls.Clear();
            frmLivros frm = new frmLivros();
            frm.TopLevel = false;
            pnlTela.Controls.Add(frm);
            frm.Show();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            pnlTela.Controls.Clear();
            frmEventos frm = new frmEventos();
            frm.TopLevel = false;
            pnlTela.Controls.Add(frm);
            frm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            pnlTela.Controls.Clear();
            frmUsuarios frm = new frmUsuarios();
            frm.TopLevel = false;
            pnlTela.Controls.Add(frm);
            frm.Show();
        }
    }
}
