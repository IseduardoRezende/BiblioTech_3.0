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
    public partial class frmAdicionarEmprestimo : Form
    {
        Livro livro;

        DataTable tabelaUsuario = new DataTable();

        Panel panelUsuario;

        private List<int> UsuariosRemovidos;

        int IndiceParaRemocao;

        Usuario usuarioSelecionado;

        CustomDatePicker prazoEmprestimo;

        DataGridView viewLivro;

        public frmAdicionarEmprestimo(Livro livro, DataTable dataTable, Panel panel, CustomDatePicker prazoEmprestimo, DataGridView view)
        {
            InitializeComponent();           

            this.livro = livro;
            txtISBN.Text = livro.id_isbn.ToString();
            txtNome.Text = livro.Titulo.ToString();            
            
            tabelaUsuario = dataTable;
            
            panelUsuario = panel;
            viewLivro = view;

            this.prazoEmprestimo = prazoEmprestimo;

            UsuariosRemovidos = new List<int>();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja cancelar o empréstimo", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2))
            {
                this.Close();
            }
        }

        private void frmAdicionarEmprestimo_Load(object sender, EventArgs e)
        {
            dgvAddUsuario.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvAddUsuario);

            dgvAddUsuario.DataSource = tabelaUsuario;

            if (prazoEmprestimo != null)
            {
                cdpData.Value = DateTime.Parse(prazoEmprestimo.Value.ToString());
            }
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            var frm = new frmAdicionarUsuarioEmprestimo(livro, viewLivro, panelUsuario, cdpData);
            this.Hide();
            frm.ShowDialog();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Título do Livro:")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.White;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Título do Livro:";
                txtNome.ForeColor = Color.FromArgb(92, 92, 155);
            }
        }

        private void txtISBN_Enter(object sender, EventArgs e)
        {
            if (txtISBN.Text == "ISBN do Livro:")
            {
                txtISBN.Text = "";
                txtISBN.ForeColor = Color.White;
            }
        }

        private void txtISBN_Leave(object sender, EventArgs e)
        {
            if (txtISBN.Text == "")
            {
                txtISBN.Text = "ISBN do Livro:";
                txtISBN.ForeColor = Color.FromArgb(92, 92, 155);
            }
        }

        private void frmAdicionarEmprestimo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string nome = txtBusca.Text;

            var dao = new UsuarioDAO();
            dgvAddUsuario.DataSource = dao.PesquisarUsuario(nome);
            
            if (dgvAddUsuario.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum usuário encontrado");
                dgvAddUsuario.DataSource = dao.ListarUsuario();
            }
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtBusca.Text + "%";

            var dao = new UsuarioDAO();
            dgvAddUsuario.DataSource = dao.BuscarPorNome(nome);
        }       

        private void btnConfirmarEmprestimo_Click(object sender, EventArgs e)
        {
            if (dgvAddUsuario.Rows.Count >= 2 || dgvAddUsuario.Rows.Count == 0)
            {
                MessageBox.Show("Não é possível efetuar o Empréstimo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var obj = new Emprestimo();

                    obj.id_usuario = int.Parse(dgvAddUsuario.CurrentRow.Cells[0].Value.ToString());
                    obj.id_isbn = txtISBN.Text;
                    obj.dta_entrega = cdpData.Value;
                    obj.dta_retirada = DateTime.Today;
                    obj.status_emprestimo = true;

                    var dao = new EmprestimoDAO();
                    dao.AdicionarEmprestimo(obj);

                    var dao_Livro = new LivroDAO();
                    dao_Livro.LivroEmprestado(obj.id_isbn, false);

                    this.Close();

                    var utils = new Utils();
                    utils.refreshInfoLivro(viewLivro, panelUsuario);
                    panelUsuario.Controls.Clear();

                    var frm = new frmLivros();
                    frm.TopLevel = false;

                    panelUsuario.Controls.Add(viewLivro);
                    frm.Show();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Clique em gerenciar e escolha um usuário", "Erro Empréstimo", (MessageBoxButtons) MessageBoxIcon.Error);                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Empréstimo inválido");
                    throw;
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado == null)
            {
                MessageBox.Show("Selecione um usuário");
                return;
            }
            else if (DialogResult.Yes == MessageBox.Show($"Remover {usuarioSelecionado.Nome}", "Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    UsuariosRemovidos.Add(usuarioSelecionado.id_usuario);

                    var linha = dgvAddUsuario.Rows[IndiceParaRemocao];
                    dgvAddUsuario.Rows.Remove(linha);

                    MessageBox.Show("usuário removido com sucesso !");

                    lblUsuarioEscolhido.Text = string.Empty;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao excluir usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }            
        }

        private void dgvAddUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuario = new Usuario();
            usuario.id_usuario = int.Parse(dgvAddUsuario.CurrentRow.Cells[0].Value.ToString());
            usuario.Nome = dgvAddUsuario.CurrentRow.Cells[1].Value.ToString();

            lblUsuarioEscolhido.Text = $"{usuario.Nome} selecionadoª";

            this.IndiceParaRemocao = e.RowIndex;
            this.usuarioSelecionado = usuario;
        }
    }
}
