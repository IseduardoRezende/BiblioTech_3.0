using BiblioTech_3._0.DAO;
using BiblioTech_3._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech_3._0.View
{
    public partial class frmAutor : Form
    {
        DataGridView tabelaAutor;

        Panel panelAutor;

        public frmAutor(DataGridView view, Panel panel)
        {
            InitializeComponent();
 
            tabelaAutor = view;
            panelAutor = panel;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            var utils = new Utils();
            utils.refreshInfoAutor(tabelaAutor, panelAutor);
            panelAutor.Controls.Clear();
            var frm = new frmAdicionarLivro(tabelaAutor, panelAutor);
            frm.TopLevel = false;
            panelAutor.Controls.Add(tabelaAutor);
            frm.Show();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            View.frmAdicionarAutor frm = new frmAdicionarAutor(dgvAutor, pnlAutor);
            frm.ShowDialog();
        }

        private void frmAutor_Load(object sender, EventArgs e)
        {
            dgvAutor.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvAutor);

            var dao = new AutorDAO();
            dgvAutor.DataSource = dao.ListarAutor();
        }

        private void frmAutor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.BlueViolet, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
