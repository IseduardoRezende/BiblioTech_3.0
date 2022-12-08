using BiblioTech_3._0.DAO;
using BiblioTech_3._0.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BiblioTech_3._0
{
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            dgvEvento.DefaultCellStyle.ForeColor = Color.Black;

            var dao = new EventoDAO();
            dgvEvento.DataSource = dao.ListarEventos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var add = new frmAdicionarEvento();
            add.Show();
        }

        private void dgvEvento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = new Evento();
            obj.id_evento = int.Parse(dgvEvento.CurrentRow.Cells[0].Value.ToString());
            obj.Tema = dgvEvento.CurrentRow.Cells[1].Value.ToString();
            obj.desc_evento = dgvEvento.CurrentRow.Cells[2].Value.ToString();
            obj.data_evento = DateTime.Parse(dgvEvento.CurrentRow.Cells[3].Value.ToString());
        }
    }
}
