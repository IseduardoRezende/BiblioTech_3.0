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
    public partial class frmAdicionarParticipante : Form
    {
        DataGridView tabelaParticipantes;

        DataTable tblParticipantes = new DataTable();

        UsuarioEvento UsuarioSelecionado;

        string tema;

        string descricao;

        CustomDatePicker dataEvento;
        
        Panel panelParticipantes;

        public frmAdicionarParticipante(DataGridView view, Panel panel, string tema, string descricao, CustomDatePicker dataEvento)
        {
            InitializeComponent();
            tabelaParticipantes = view;
            panelParticipantes = panel;

            tblParticipantes.Columns.Add("Código");
            tblParticipantes.Columns.Add("Nome");

            this.descricao = descricao;
            this.tema = tema;
            this.dataEvento = dataEvento;
        }
                           
        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtBusca.Text + "%";

            var dao = new UsuarioDAO();
            dgvAddParticipantes.DataSource = dao.BuscarPorNome(nome);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Você tem certeza que deseja cancelar a inserção", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void frmAdicionarParticipante_Load_1(object sender, EventArgs e)
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
            dao.PesquisarUsuario(nome);

            if (dgvAddParticipantes.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum participante encontrado");
                dgvAddParticipantes.DataSource = dao.ListarUsuario();

                txtBusca.Text = string.Empty;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado == null)
            {
                MessageBox.Show("Selecione um participante e adicione");
                return;
            }
            else
            {
                var frm = new frmAdicionarEvento(tblParticipantes, panelParticipantes, tabelaParticipantes, tema, descricao, dataEvento);
                frm.ShowDialog();

                this.Close();
            }           
        }

        private void dgvAddParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nome = dgvAddParticipantes.CurrentRow.Cells[1].Value.ToString();

            var usuarioEvento = new UsuarioEvento();
            usuarioEvento.id_usuario = int.Parse(dgvAddParticipantes.CurrentRow.Cells[0].Value.ToString());

            lblParticipanteSelecionado.Text = $"{usuario.Nome} selecionadoª";

            this.UsuarioSelecionado = usuarioEvento;
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
                //Adiciona um participante por vez no datatable participantes:

                int id;
                string nome;

                id = int.Parse(dgvAddParticipantes.CurrentRow.Cells[0].Value.ToString());
                nome = dgvAddParticipantes.CurrentRow.Cells[1].Value.ToString();

                tblParticipantes.Rows.Add(id, nome);

                MessageBox.Show($"{nome} Adicionado com Sucesso");
            }                       
        }

        private void frmAdicionarParticipante_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.BlueViolet, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
