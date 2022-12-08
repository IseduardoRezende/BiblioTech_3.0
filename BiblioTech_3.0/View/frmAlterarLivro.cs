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
    public partial class frmAlterarLivro : Form
    {
        private readonly Livro livro;

        private Autor AutorSelecionado;

        private DataGridView tabelaLivro;

        private Panel panelLivro;

        public string autorAtivo;

        public void SelecionaAutor(string nomeAutor)
        {            
            foreach (DataGridViewRow row in dgvAutores.Rows)
            {
                if (row.Cells[1].Value.ToString() == nomeAutor)
                {                    
                    row.Selected = true;                    
                }
            }
        }

        public frmAlterarLivro(Livro livro, DataGridView view, Panel panel, string nomeAutor)
        {
            InitializeComponent();
            this.livro = livro;
            txtISBN.Text = livro.id_isbn.ToString();                    
            txtTitulo.Text = livro.Titulo;
            txtCDD.Text = livro.CDD;
            txtExemplar.Text = livro.Exemplar;
            txtVolume.Text = livro.Volume;

            autorAtivo = nomeAutor;

            tabelaLivro = view;
            panelLivro = panel;
        }
   
        private void Button6_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja cancelar a alteração do Livro", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                this.Close();
            } 
        }

        private void frmAlterarLivro_Load(object sender, EventArgs e)
        {
            dgvAutores.DefaultCellStyle.ForeColor = Color.White;

            var es_Dao = new EstanteDAO();
            var estantes = es_Dao.ListarEstanteNoComboBox();
            cbEstante.DataSource = estantes;
            cbEstante.DisplayMember = "Estante";
            cbEstante.ValueMember = "id_estante";
            var estanteSelecionada = estantes.AsEnumerable().SingleOrDefault(r => r.Field<int>("id_estante") == livro.id_estante);
            cbEstante.SelectedIndex = estantes.Rows.IndexOf(estanteSelecionada);

            var pr_Dao = new PrateleiraDAO();
            var prateleiras = pr_Dao.ListarPrateleiraNoComboBox();
            cbPrateleira.DataSource = prateleiras;
            cbPrateleira.DisplayMember = "Prateleira";
            cbPrateleira.ValueMember = "id_prateleira";
            var prateleiraSelecionada = prateleiras.AsEnumerable().SingleOrDefault(r => r.Field<int>("id_prateleira") == livro.id_prateleira);
            cbPrateleira.SelectedIndex = prateleiras.Rows.IndexOf(prateleiraSelecionada);

            var ge_Dao = new GeneroDAO();
            var generos = ge_Dao.ListarGenero();
            cbGenero.DataSource = generos;
            cbGenero.DisplayMember = "Gênero";
            cbGenero.ValueMember = "Código";
            var generoSelecionado = generos.AsEnumerable().FirstOrDefault(r => r.Field<int>("Código") == livro.id_genero);
            cbGenero.SelectedIndex = generos.Rows.IndexOf(generoSelecionado);

            var ed_Dao = new EditoraDAO();
            var editoras = ed_Dao.ListarEditora();
            cbEditora.DataSource = editoras;
            cbEditora.DisplayMember = "Editora";
            cbEditora.ValueMember = "Código";
            var editoraSelecionada = editoras.AsEnumerable().FirstOrDefault(r => r.Field<int>("Código") == livro.id_editora);
            cbEditora.SelectedIndex = editoras.Rows.IndexOf(editoraSelecionada);
            
            var au_Dao = new AutorDAO();
            dgvAutores.DataSource = au_Dao.ListarAutor();

            foreach (DataGridViewRow row in dgvAutores.Rows)
            {
                row.Selected = false;
            }         

            SelecionaAutor(autorAtivo);

            lblAutorSelecionado.Text = $"Autor(a) selecionado(a): {autorAtivo}";
        }

        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "Título do Livro:")
            {
                txtTitulo.Text = "";
                txtTitulo.ForeColor = Color.White;
            }
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                txtTitulo.Text = "Título do Livro:";
                txtTitulo.ForeColor = Color.FromArgb(92, 92, 155);
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

        private void txtExemplar_Enter(object sender, EventArgs e)
        {
            if (txtExemplar.Text == "Exemplar do Livro:")
            {
                txtExemplar.Text = "";
                txtExemplar.ForeColor = Color.White;
            }
        }

        private void txtExemplar_Leave(object sender, EventArgs e)
        {
            if (txtExemplar.Text == "")
            {
                txtExemplar.Text = "Exemplar do Livro:";
                txtExemplar.ForeColor = Color.FromArgb(92, 92, 155);
            }
        }

        private void txtVolume_Enter(object sender, EventArgs e)
        {
            if (txtVolume.Text == "Volume do Livro:")
            {
                txtVolume.Text = "";
                txtVolume.ForeColor = Color.White;
            }
        }

        private void txtVolume_Leave(object sender, EventArgs e)
        {
            if (txtVolume.Text == "")
            {
                txtVolume.Text = "Volume do Livro:";
                txtVolume.ForeColor = Color.FromArgb(92, 92, 155);
            }
        }

        private void txtCodGenero_Enter(object sender, EventArgs e)
        {
            if (txtCDD.Text == "CDD:")
            {
                txtCDD.Text = "";
                txtCDD.ForeColor = Color.White;
            }
        }

        private void txtCodGenero_Leave(object sender, EventArgs e)
        {
            if (txtCDD.Text == "")
            {
                txtCDD.Text = "CDD:";
                txtCDD.ForeColor = Color.FromArgb(92, 92, 155);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            livro.id_isbn = txtISBN.Text;
            livro.id_genero = int.Parse(cbGenero.SelectedValue.ToString());
            livro.id_estante = int.Parse(cbEstante.SelectedValue.ToString());
            livro.id_editora = int.Parse(cbEditora.SelectedValue.ToString());
            livro.id_prateleira = int.Parse(cbPrateleira.SelectedValue.ToString());
            livro.id_autor = int.Parse(dgvAutores.SelectedCells[0].Value.ToString());
            livro.Titulo = txtTitulo.Text;
            livro.CDD = txtCDD.Text;
            livro.Exemplar = txtExemplar.Text;
            livro.Volume = txtVolume.Text;

            var dao = new LivroDAO();
            dao.AlterarLivro(livro);

            this.Close();

            var utils = new Utils();
            utils.refreshInfoLivro(tabelaLivro, panelLivro);
            panelLivro.Controls.Clear();
            
            var frm = new frmLivros();
            frm.TopLevel = false;
            panelLivro.Controls.Add(tabelaLivro);
            frm.Show();
        }

        private void btnGerenciarEditora_Click(object sender, EventArgs e)
        {
            var frm = new frmEditora(cbEditora);
            frm.ShowDialog();
        }

        private void btnGerenciarGenero_Click(object sender, EventArgs e)
        {
            var frm = new frmGenero(cbGenero);
            frm.ShowDialog();
        }

        private void btnGerenciarPrateleira_Click(object sender, EventArgs e)
        {
            var frm = new frmPrateleira(cbPrateleira);
            frm.ShowDialog();
        }

        private void btnGerenciarEstante_Click(object sender, EventArgs e)
        {
            var frm = new frmEstante(cbEstante);
            frm.ShowDialog();
        }

        private void btnGerenciarAutores_Click(object sender, EventArgs e)
        {
            var frm = new frmAutor(dgvAutores, pnAutores);
            frm.ShowDialog();
        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var autor = new Autor();

                autor.id_autor = int.Parse(dgvAutores.CurrentRow.Cells[0].Value.ToString());
                autor.Nome_Autor = dgvAutores.CurrentRow.Cells[1].Value.ToString();

                lblAutorSelecionado.Text = $"{autor.Nome_Autor} selecionadoª.";
                this.AutorSelecionado = autor;
            }
        }

        private void btnArquivar_Click(object sender, EventArgs e)
        {
            if (livro.Status_Emprestimo == false)
            {
                MessageBox.Show("Não é possível arquivar um livro que está emprestado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (DialogResult.Yes == MessageBox.Show("Deseja arquivar livro", "Arquivamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                var dao = new LivroDAO();

                dao.LivroArquivado(livro.id_isbn, false, false);

                dao.ListarLivroArquivado();
                MessageBox.Show("Livro arquivado com Sucesso !", "Arquivação", MessageBoxButtons.OK);

                this.Close();

                var utils = new Utils();
                utils.refreshInfoLivro(tabelaLivro, panelLivro);
                panelLivro.Controls.Clear();

                var frm = new frmLivros();
                frm.TopLevel = false;

                panelLivro.Controls.Add(tabelaLivro);
                frm.Show();
            }
        }

        private void frmAlterarLivro_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
