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
    public partial class frmEditora : Form
    {
        ComboBox box;

        DataGridView tabelaLivro;

        Panel panelLivro;

        public frmEditora(ComboBox box)
        {
            InitializeComponent();
            this.box = box;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            View.frmAdicionarEditora frm = new frmAdicionarEditora(dgvEditora, pnlEditora);
            frm.ShowDialog();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            var utils = new Utils();

            utils.refreshInfoEditoraBox(box);
            var frm = new frmAdicionarLivro(tabelaLivro, panelLivro);
            frm.TopLevel = false;
            frm.Show();
        }

        private void frmEditora_Load(object sender, EventArgs e)
        {
            dgvEditora.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvEditora);

            var dao = new EditoraDAO();
            dgvEditora.DataSource = dao.ListarEditora();
        }

        private void frmEditora_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.BlueViolet, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
