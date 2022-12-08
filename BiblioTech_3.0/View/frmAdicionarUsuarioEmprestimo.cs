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
    public partial class frmAdicionarUsuarioEmprestimo : Form
    {
        Usuario UsuarioSelecionado;

        DataGridView tabelaUsuario;

        DataTable tblUsuario = new DataTable();

        Panel panelUsuario;

        Livro livro;

        CustomDatePicker prazoEmprestimo;

        public frmAdicionarUsuarioEmprestimo(Livro livro, DataGridView view, Panel panel, CustomDatePicker prazoEmprestimo)
        {
            InitializeComponent();
            this.tabelaUsuario = view;
            this.panelUsuario = panel;

            this.livro = livro;
            this.prazoEmprestimo = prazoEmprestimo;

            tblUsuario.Columns.Add("Código");
            tblUsuario.Columns.Add("Nome");
            tblUsuario.Columns.Add("Email");
            tblUsuario.Columns.Add("Telefone");
        }

        private void frmAdicionarUsuarioEmprestimo_Load(object sender, EventArgs e)
        {
            dgvAddUsuarios.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvAddUsuarios);

            var dao = new UsuarioDAO();
            dgvAddUsuarios.DataSource = dao.ListarUsuario();
        }

        private void dgvAddUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuario = new Usuario();
            usuario.id_usuario = int.Parse(dgvAddUsuarios.CurrentRow.Cells[0].Value.ToString());
            usuario.Nome = dgvAddUsuarios.CurrentRow.Cells[1].Value.ToString();

            lblUsuarioSelecionado.Text = $"{usuario.Nome} selecionadoª";

            this.UsuarioSelecionado = usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja cancelar inserção", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Close();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado == null)
            {
                MessageBox.Show("Escolha um usuário");
                return;
            }
            else if (UsuarioSelecionado != null)
            {
                this.Close();
                
                var frm = new frmAdicionarEmprestimo(livro, tblUsuario, panelUsuario, prazoEmprestimo, tabelaUsuario);
                frm.ShowDialog();               
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string nome = txtBusca.Text;

            var dao = new UsuarioDAO();
            dgvAddUsuarios.DataSource = dao.PesquisarUsuario(nome);

            if (dgvAddUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Usuário encontrado");
                dgvAddUsuarios.DataSource = dao.ListarUsuario();

                txtBusca.Text = string.Empty;
            }
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtBusca.Text + "%";

            var dao = new UsuarioDAO();
            dgvAddUsuarios.DataSource = dao.BuscarPorNome(nome);
        }

        private void frmAdicionarUsuarioEmprestimo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.BlueViolet, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado == null)
            {
                MessageBox.Show("Selecione o usuário e adicione");
                return;
            }
            else
            {
                int id = (int)ulong.Parse(dgvAddUsuarios.CurrentRow.Cells[0].Value.ToString());
                string nome = dgvAddUsuarios.CurrentRow.Cells[1].Value.ToString();
                string email = dgvAddUsuarios.CurrentRow.Cells[2].Value.ToString();
                string telefone = dgvAddUsuarios.CurrentRow.Cells[4].Value.ToString();

                tblUsuario.Rows.Add(id, nome, email, telefone);

                MessageBox.Show($"{nome} adicionado com sucesso !");

            }
        }
    }
}