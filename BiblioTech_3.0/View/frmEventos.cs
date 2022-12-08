using BiblioTech_3._0.CustomComponents;
using BiblioTech_3._0.DAO;
using BiblioTech_3._0.Model;
using BiblioTech_3._0.View;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BiblioTech_3._0
{
    public partial class frmEventos : Form
    {
        private Evento EventoSelecionado;

        DataTable tabelaParticipante = new DataTable();

        string tema;

        string descricao;

        CustomDatePicker dataEvento;

        public frmEventos()
        {
            InitializeComponent();            
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarEvento add = new frmAdicionarEvento(tabelaParticipante, pnlEventos, dgvEvento, tema, descricao, dataEvento);
            add.ShowDialog();
        }

        private void BtnArquivo_Click(object sender, EventArgs e)
        {
            frmEventosArquivados frm = new View.frmEventosArquivados(dgvEvento, pnlEventos);
            this.pnlEventos.Controls.Remove(this);
            frm.ShowDialog();
        }

        private void FrmEventos_Load(object sender, EventArgs e)
        {
            dgvEvento.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvEvento);

            var dao = new EventoDAO();
            dgvEvento.DataSource = dao.ListarEventos();
        }
      
        private void btnBusca_Click(object sender, EventArgs e)
        {
            string nome = txtBusca.Text;

            var dao = new EventoDAO();
            dgvEvento.DataSource = dao.PesquisarEvento(nome);

            if (dgvEvento.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum evento encontrado");
                dgvEvento.DataSource = dao.ListarEventos();

                txtBusca.Text = string.Empty;
            }
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtBusca.Text + "%";

            var dao = new EventoDAO();
            dgvEvento.DataSource = dao.BuscarEventoPorNome(nome);
        }

        private void btnArquivar_Click(object sender, EventArgs e)
        {
            if (EventoSelecionado == null)
            {
                MessageBox.Show("Nenhum evento selecionado", "Arquivação");
                return;
            }
            else
            {
                var dao = new EventoDAO();
                dao.AlterarEventoArquivado(EventoSelecionado.id_evento, false);

                MessageBox.Show("Evento arquivado com sucesso");
                dgvEvento.DataSource = dao.ListarEventos();
            }
        }

        private void dgvEvento_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var obj = new Evento();
                obj.id_evento = int.Parse(dgvEvento.CurrentRow.Cells[0].Value.ToString());
                obj.Tema = dgvEvento.CurrentRow.Cells[1].Value.ToString();
                obj.desc_evento = dgvEvento.CurrentRow.Cells[2].Value.ToString();
                obj.data_evento = DateTime.Parse(dgvEvento.CurrentRow.Cells[3].Value.ToString());
                this.EventoSelecionado = obj;
            }
        }

        private void dgvEvento_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var frmAlterar = new frmAlterarEvento(EventoSelecionado, dgvEvento, pnlEventos, tabelaParticipante, descricao, tema, dataEvento);
            frmAlterar.ShowDialog();
        }       
    }
}