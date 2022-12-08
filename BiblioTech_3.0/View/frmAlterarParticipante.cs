using BiblioTech_3._0.CustomComponents;
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
    public partial class frmAlterarParticipante : Form
    {
        UsuarioEvento UsuarioSelecionado;

        int id_evento;

        Evento evento;

        DataTable dataTableParticipante;

        DataGridView viewParticipante;

        Panel panelParticipante;

        string descricao;

        string tema;

        CustomDatePicker dataEvento;
      
        public frmAlterarParticipante(int id_evento, Evento evento, DataTable dataTableParticipante, DataGridView viewParticipante, Panel panelParticipante, 
                                      string descricao, string tema, CustomDatePicker dataEvento)
        {
            InitializeComponent();
            this.id_evento = id_evento;

            this.evento = evento;

            this.dataTableParticipante = dataTableParticipante;
            
            this.viewParticipante = viewParticipante;
            this.panelParticipante = panelParticipante;

            this.descricao = descricao;
            this.tema = tema;
            this.dataEvento = dataEvento;
        }

        private void frmAlterarParticipante_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.BlueViolet, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        private void frmAlterarParticipante_Load(object sender, EventArgs e)
        {
            dgvAddParticipantes.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvAddParticipantes);

            var dao = new UsuarioDAO();
            dgvAddParticipantes.DataSource = dao.ListarUsuario();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string nome = txtBusca.Text;

            var dao = new UsuarioDAO();
            dgvAddParticipantes.DataSource = dao.PesquisarUsuario(nome);

            if (dgvAddParticipantes.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum usuário encontrado");
                dgvAddParticipantes.DataSource = dao.ListarUsuario();

                txtBusca.Text = string.Empty;
            }
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtBusca.Text + "%";

            var dao = new UsuarioDAO();
            dgvAddParticipantes.DataSource = dao.BuscarPorNome(nome);
        }       

        private void dgvAddParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nome = dgvAddParticipantes.CurrentRow.Cells[1].Value.ToString();

            var usuarioEvento = new UsuarioEvento();
            usuarioEvento.id_usuario = int.Parse(dgvAddParticipantes.CurrentRow.Cells[0].Value.ToString());

            this.UsuarioSelecionado = usuarioEvento;
            lblParticipanteEscolhido.Text = $"{usuario.Nome} selecionadoª";
        }

        private void btnAdicionarParticipante_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado == null)
            {
                MessageBox.Show("Selecione os participante(s)");
                return;
            }
            else
            {
                var obj = new UsuarioEvento();

                obj.id_usuario = int.Parse(dgvAddParticipantes.CurrentRow.Cells[0].Value.ToString());
                obj.id_evento = id_evento;

                //Insere um novo participante:

                var dao = new UsuarioEventoDAO();
                dao.AdicionarParticipante(obj);

                MessageBox.Show("Participante adicionadoª com sucesso !");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Cancelar a inserção ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {                
                this.Close();
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado == null)
            {
                MessageBox.Show("Selecione o participante e adicione");
                return;
            }
            else
            {
                MessageBox.Show("Adicionar Participante(s)", "Participante(s)", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); ;

                var frm = new frmAlterarEvento(evento, viewParticipante, panelParticipante, dataTableParticipante, descricao, tema, dataEvento);
                frm.ShowDialog();

                this.Hide();
            }
        }
    }
}