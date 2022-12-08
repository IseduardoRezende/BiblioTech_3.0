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
    public partial class frmEventosArquivados : Form
    {
        private Evento EventoSelecionado;

        public DataGridView tabelaEventosArquivados;
        public Panel panelEventosArquivados;

        public frmEventosArquivados(DataGridView grid, Panel panel)
        {
            InitializeComponent();
            tabelaEventosArquivados = grid;
            panelEventosArquivados = panel;
        }
      
        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string nome = txtBusca.Text;

            var dao = new EventoDAO();
            dgvEventoArquivado.DataSource = dao.PesquisarEventoArquivado(nome);

            if (dgvEventoArquivado.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum evento encontrado");
                dgvEventoArquivado.DataSource = dao.ListarEventosArquivados();

                txtBusca.Text = string.Empty;
            }
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtBusca.Text + "%";

            var dao = new EventoDAO();
            dgvEventoArquivado.DataSource = dao.BuscarEventoArquivadoPorNome(nome);
        }

        private void frmEventosArquivados_Load(object sender, EventArgs e)
        {
            dgvEventoArquivado.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvEventoArquivado);

            var dao = new EventoDAO();
            dgvEventoArquivado.DataSource = dao.ListarEventosArquivados();
        }
        
        private void btnDesarquivar_Click(object sender, EventArgs e)
        {
            if (EventoSelecionado == null)
            {
                MessageBox.Show("Nenhum evento selecionado");
                return;
            }

            var dao = new EventoDAO();
            dao.AlterarEventoArquivado(EventoSelecionado.id_evento, true);

            MessageBox.Show("Desarquivado com sucesso !");
            this.Close();

            var utils = new Utils();

            utils.refreshInfoEvento(tabelaEventosArquivados, panelEventosArquivados);

            panelEventosArquivados.Controls.Clear();
            var frm = new frmEventos();
            frm.TopLevel = false;

            panelEventosArquivados.Controls.Add(tabelaEventosArquivados);
            frm.Show();
        }

        private void dgvEventoArquivado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = new Evento();
            obj.id_evento = int.Parse(dgvEventoArquivado.CurrentRow.Cells[0].Value.ToString());
            obj.Tema = dgvEventoArquivado.CurrentRow.Cells[1].Value.ToString();
            obj.desc_evento = dgvEventoArquivado.CurrentRow.Cells[2].Value.ToString();
            obj.data_evento = DateTime.Parse(dgvEventoArquivado.CurrentRow.Cells[3].Value.ToString());

            lblEventoEscolhido.Text = $"Evento selecionado: {obj.Tema}";
            EventoSelecionado = obj;
        }

        private void frmEventosArquivados_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
