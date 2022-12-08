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
    public partial class frmGenero : Form
    {
        ComboBox box;

        DataGridView tabelaLivro;

        Panel panelLivro;

        public frmGenero(ComboBox box)
        {
            InitializeComponent();
            this.box = box;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            var utils = new Utils();

            utils.refreshInfoGeneroBox(box);
            var frm = new frmAdicionarLivro(tabelaLivro, panelLivro);
            frm.TopLevel = false;
            frm.Show();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            View.frmAdicionarGenero frm = new View.frmAdicionarGenero(dgvGenero, pnlGenero);
            frm.ShowDialog();
        }

        private void frmGenero_Load(object sender, EventArgs e)
        {
            dgvGenero.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvGenero);

            var dao = new GeneroDAO();
            dgvGenero.DataSource = dao.ListarGenero();
        }

        private void frmGenero_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.BlueViolet, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
