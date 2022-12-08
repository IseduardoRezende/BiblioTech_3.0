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
    public partial class frmLivros : Form
    {
        Livro LivroSelecionado;

        DataTable tblUsuario;

        CustomDatePicker prazoEvento;

        public frmLivros()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, System.EventArgs e)
        {
            var frm = new frmAdicionarLivro(dgvLivro, pnlLivro);
            frm.ShowDialog();
        }

        private void BtnEmprestar_Click(object sender, System.EventArgs e)
        {
            if (LivroSelecionado == null)
            {
                MessageBox.Show("Nenhum livro selecionado para Empréstimo", "Empréstimo");
                return;
            }
            else if (LivroSelecionado.Status_Emprestimo == false)
            {
                MessageBox.Show($"{LivroSelecionado.Titulo} está em uso", "Empréstimo indisponível", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
                LivroSelecionado.id_isbn = dgvLivro.CurrentRow.Cells[0].Value.ToString();
                LivroSelecionado.Titulo = dgvLivro.CurrentRow.Cells[1].Value.ToString();

                LivroSelecionado.Status_Emprestimo = bool.Parse(dgvLivro.CurrentRow.Cells[10].Value.ToString());

                var frm = new frmAdicionarEmprestimo(LivroSelecionado, tblUsuario, pnlLivro, prazoEvento, dgvLivro);
                frm.ShowDialog();                     
        }

        private void BtnArquivo_Click(object sender, System.EventArgs e)
        {
            View.frmLivrosArquivados frm = new View.frmLivrosArquivados(dgvLivro, pnlLivro);
            frm.ShowDialog();
        }

        private void frmLivros_Load(object sender, System.EventArgs e)
        {
            dgvLivro.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvLivro);

            var dao = new LivroDAO();
            dgvLivro.DataSource = dao.ListarLivro();

            dgvLivro.Columns[11].Visible = false;
            dgvLivro.Columns[12].Visible = false;
            dgvLivro.Columns[13].Visible = false;
            dgvLivro.Columns[14].Visible = false;
            dgvLivro.Columns[15].Visible = false;
            dgvLivro.Columns[16].Visible = false;
        }

        private void dgvLivro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var livro = new Livro();

            livro.id_isbn = dgvLivro.CurrentRow.Cells[0].Value.ToString();
            livro.Titulo =  dgvLivro.CurrentRow.Cells[1].Value.ToString();
            livro.id_genero = int.Parse(dgvLivro.CurrentRow.Cells[13].Value.ToString());
            livro.CDD = dgvLivro.CurrentRow.Cells[3].Value.ToString();
            string nomeAutor = dgvLivro.CurrentRow.Cells[4].Value.ToString();
            livro.id_autor = int.Parse(dgvLivro.CurrentRow.Cells[14].Value.ToString());            
            livro.id_editora = int.Parse(dgvLivro.CurrentRow.Cells[12].Value.ToString());
            livro.Exemplar = dgvLivro.CurrentRow.Cells[6].Value.ToString();
            livro.Volume = dgvLivro.CurrentRow.Cells[7].Value.ToString();
            livro.id_estante = int.Parse(dgvLivro.CurrentRow.Cells[16].Value.ToString());
            livro.id_prateleira = int.Parse(dgvLivro.CurrentRow.Cells[15].Value.ToString());
            livro.Status_Emprestimo = bool.Parse(dgvLivro.CurrentRow.Cells[10].Value.ToString());

            var frm = new frmAlterarLivro(livro, dgvLivro, pnlLivro, nomeAutor);
            frm.Show();
        }
       
        private void btnBusca_Click(object sender, EventArgs e)
        {
            string titulo = txtBusca.Text;

            var dao = new LivroDAO();

            dgvLivro.DataSource = dao.PesquisarPorLivro(titulo);

            if (dgvLivro.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Livro encontrado");
                dgvLivro.DataSource = dao.ListarLivro();

                txtBusca.Text = string.Empty;
            }
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string titulo = "%" + txtBusca.Text + "%";

            var dao = new LivroDAO();

            dgvLivro.DataSource = dao.BuscarLivroPorTitulo(titulo);
        }

        private void dgvLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var livro = new Livro();
                livro.id_isbn = dgvLivro.CurrentRow.Cells[0].Value.ToString();
                livro.Titulo = dgvLivro.CurrentRow.Cells[1].Value.ToString();

                livro.Status_Emprestimo = bool.Parse(dgvLivro.CurrentRow.Cells[10].Value.ToString());
                
                this.LivroSelecionado = livro;                                
            }
        }
    }
}
