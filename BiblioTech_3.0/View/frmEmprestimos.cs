using BiblioTech_3._0.DAO;
using BiblioTech_3._0.Model;
using BiblioTech_3._0.View;
using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BiblioTech_3._0
{
    public partial class frmEmprestimos : Form
    {
        DataTable tabelaEmprestimo;

        Livro livroSelecionado;

        Emprestimo emprestimoSelecionado;

        DataTable id_remover;

        public frmEmprestimos()
        {
            InitializeComponent();
        }

        private void BtnArquivo_Click(object sender, System.EventArgs e)
        {
            frmEmprestimosArquivados arqEmprestimo = new frmEmprestimosArquivados(dgvEmprestimo, pnlEmprestimo);
            arqEmprestimo.ShowDialog();
        }

        private void frmEmprestimos_Load(object sender, System.EventArgs e)
        {
            dgvEmprestimo.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvEmprestimo);

            var dao = new EmprestimoDAO();
            dgvEmprestimo.DataSource = dao.ListarEmprestimo();

            int atrasados = 0;

            if (dgvEmprestimo.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvEmprestimo.Rows)
                {
                    if (DateTime.Today > DateTime.Parse(row.Cells[7].Value.ToString()))
                    {
                        atrasados += 1;
                    }
                }
            }
            if (atrasados == 0)
            {
                return;
            }
            else
            {
                MessageBox.Show($"{atrasados} livros estão atrasados ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }            

        private void dgvEmprestimo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var frm = new frmAlterarEmprestimo(tabelaEmprestimo, pnlEmprestimo, dgvEmprestimo, livroSelecionado, emprestimoSelecionado);
            frm.ShowDialog();
        }

        private void dgvEmprestimo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Emprestimo = new Emprestimo();
            Emprestimo.id_emprestimo = int.Parse(dgvEmprestimo.CurrentRow.Cells[0].Value.ToString());
            Emprestimo.dta_entrega = DateTime.Parse(dgvEmprestimo.CurrentRow.Cells[7].Value.ToString());

            var Livro = new Livro();
            Livro.id_isbn = dgvEmprestimo.CurrentRow.Cells[5].Value.ToString();
            Livro.Titulo = dgvEmprestimo.CurrentRow.Cells[4].Value.ToString();

            this.livroSelecionado = Livro;
            this.emprestimoSelecionado = Emprestimo;
        }

        private void btnDevolvido_Click(object sender, EventArgs e)
        {
            if (livroSelecionado == null || emprestimoSelecionado == null)
            {
                MessageBox.Show("Nenhum emprestimo selecionado");
                return;
            }

            var dao = new EmprestimoDAO();
            dao.EmprestimoAtivo(emprestimoSelecionado.id_emprestimo, false, emprestimoSelecionado.dta_entrega = DateTime.Now);

            var dao_Livro = new LivroDAO();
            dao_Livro.LivroEmprestado(livroSelecionado.id_isbn, true);

            MessageBox.Show("Devolução efetuada com Sucesso !");
            dgvEmprestimo.DataSource = dao.ListarEmprestimo();
        }
    }
}