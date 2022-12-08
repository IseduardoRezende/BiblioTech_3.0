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
    public partial class frmLivrosArquivados : Form
    {
        private Livro LivroSelecionado;

        private DataGridView tabelaLivroArquivado;

        private Panel panelArquivado;

        public frmLivrosArquivados(DataGridView view, Panel panel)
        {
            InitializeComponent();

            tabelaLivroArquivado = view;
            panelArquivado = panel;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void frmLivrosArquivados_Load(object sender, EventArgs e)
        {
            dgvLivrosArquivados.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvLivrosArquivados);

            var dao = new LivroDAO();
            dgvLivrosArquivados.DataSource = dao.ListarLivroArquivado();

            dgvLivrosArquivados.Columns[11].Visible = false;
        }

        private void dgvLivrosArquivados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var livro = new Livro();

            livro.id_isbn = dgvLivrosArquivados.CurrentRow.Cells[0].Value.ToString();
            livro.Titulo = dgvLivrosArquivados.CurrentRow.Cells[1].Value.ToString();
            livro.id_genero = int.Parse(dgvLivrosArquivados.CurrentRow.Cells[2].ColumnIndex.ToString());
            livro.CDD = dgvLivrosArquivados.CurrentRow.Cells[3].Value.ToString();
            livro.id_autor = int.Parse(dgvLivrosArquivados.CurrentRow.Cells[4].ColumnIndex.ToString());
            livro.id_editora = int.Parse(dgvLivrosArquivados.CurrentRow.Cells[5].ColumnIndex.ToString());
            livro.Exemplar = dgvLivrosArquivados.CurrentRow.Cells[6].Value.ToString();
            livro.Volume = dgvLivrosArquivados.CurrentRow.Cells[7].Value.ToString();
            livro.id_estante = int.Parse(dgvLivrosArquivados.CurrentRow.Cells[8].Value.ToString());
            livro.id_prateleira = int.Parse(dgvLivrosArquivados.CurrentRow.Cells[9].Value.ToString());

            lblLivroSelecionado.Text = $"Livro selecionado: {livro.Titulo}";

            LivroSelecionado = livro;
        }

        private void btnDesarquivar_Click(object sender, EventArgs e)
        {
            if (LivroSelecionado == null)
            {
                MessageBox.Show("Selecione o Livro que deseja desarquivar");
                return;
            }

            var dao = new LivroDAO();
            dao.LivroArquivado(LivroSelecionado.id_isbn, true, true);

            MessageBox.Show("Desarquivado com Sucesso !");

            this.Close();

            var utils = new Utils();
            utils.refreshInfoLivro(tabelaLivroArquivado, panelArquivado);

            panelArquivado.Controls.Clear();

            var frm = new frmLivros();
            frm.TopLevel = false;
            panelArquivado.Controls.Add(tabelaLivroArquivado);
            
            frm.Show();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string titulo = txtBusca.Text;

            var dao = new LivroDAO();

            dgvLivrosArquivados.DataSource = dao.PesquisarPorLivroArquivado(titulo);

            if (dgvLivrosArquivados.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Livro encontrado");
                dgvLivrosArquivados.DataSource = dao.ListarLivroArquivado();

                txtBusca.Text = string.Empty;
            }
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string titulo = "%" + txtBusca.Text + "%";

            var dao = new LivroDAO();

            dgvLivrosArquivados.DataSource = dao.BuscarLivroPorTituloArquivado(titulo);
        }

        private void frmLivrosArquivados_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
