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
    public partial class frmEmprestimosArquivados : Form
    {
        Emprestimo emprestimoSelecionado;

        Livro livroSelecionado;

        DataGridView tabelaEmprestimo;

        Panel panelEmprestimo;

        public frmEmprestimosArquivados(DataGridView view, Panel panel)
        {
            InitializeComponent();

            tabelaEmprestimo = view;
            panelEmprestimo = panel;
        }       
      
        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmprestimosArquivados_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        private void frmEmprestimosArquivados_Load(object sender, EventArgs e)
        {
            dgvEmprestimoArquivado.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvEmprestimoArquivado);

            var dao = new EmprestimoDAO();
            dgvEmprestimoArquivado.DataSource = dao.ListarEmprestimoArquivado();
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string titulo = "%" + txtBusca.Text + "%";

            var dao = new EmprestimoDAO();
            dgvEmprestimoArquivado.DataSource = dao.BuscarEmprestimoPorNome(titulo);
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string titulo = txtBusca.Text;

            var dao = new EmprestimoDAO();
            dgvEmprestimoArquivado.DataSource = dao.PesquisarEmprestimo(titulo);

            if (dgvEmprestimoArquivado.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum empréstimo encontrado !");
                dgvEmprestimoArquivado.DataSource = dao.ListarEmprestimoArquivado();

                txtBusca.Text = string.Empty;
            }
        }

        private void dgvEmprestimoArquivado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var emprestimo = new Emprestimo();
            emprestimo.id_emprestimo = int.Parse(dgvEmprestimoArquivado.CurrentRow.Cells[0].Value.ToString());
            emprestimo.dta_entrega = DateTime.Parse(dgvEmprestimoArquivado.CurrentRow.Cells[6].Value.ToString());

            var livro = new Livro();
            livro.id_isbn = dgvEmprestimoArquivado.CurrentRow.Cells[5].Value.ToString();
            livro.Titulo = dgvEmprestimoArquivado.CurrentRow.Cells[4].Value.ToString();       

            lblEmprestimoSelecionado.Text = $"Livro selecionado: {livro.Titulo}";
            
            this.livroSelecionado = livro;
            this.emprestimoSelecionado = emprestimo;
        }

        private void btnDesarquivar_Click(object sender, EventArgs e)
        {
            if (livroSelecionado == null || emprestimoSelecionado == null)
            {
                MessageBox.Show("Selecione um livro");
                return;
            }

            var dao = new EmprestimoDAO();
            dao.EmprestimoAtivo(emprestimoSelecionado.id_emprestimo, true, emprestimoSelecionado.dta_entrega);

            var dao_Livro = new LivroDAO();
            dao_Livro.LivroEmprestado(livroSelecionado.id_isbn, false);

            MessageBox.Show("Empréstimo ativado com Sucesso !");            
            dgvEmprestimoArquivado.DataSource = dao.ListarEmprestimoArquivado();

            this.Close();

            var utils = new Utils();
            utils.refreshInfoEmprestimo(tabelaEmprestimo, panelEmprestimo);
            panelEmprestimo.Controls.Clear();

            var frm = new frmEmprestimos();
            frm.TopLevel = false;

            panelEmprestimo.Controls.Add(tabelaEmprestimo);
            frm.Show();
        }
    }
}