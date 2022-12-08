using BiblioTech_3._0.DAO;
using BiblioTech_3._0.Model;
using Org.BouncyCastle.Math;
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
    public partial class frmAdicionarLivro : Form
    {
        private Autor AutorSelecionado;

        private DataGridView tabelaLivro;

        private Panel panelLivro;

        public frmAdicionarLivro(DataGridView view, Panel panel)
        {
            InitializeComponent();

            tabelaLivro = view;
            panelLivro = panel;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja cancelar o cadastro do Livro", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            View.frmEditora frm = new View.frmEditora(cbEditora);
            frm.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            View.frmGenero frm = new View.frmGenero(cbGenero);
            frm.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var frm = new frmAutor(dgvAutores, pnAutores);
            frm.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            View.frmEstante frm = new View.frmEstante(cbEstante);
            frm.ShowDialog();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            View.frmPrateleira frm = new View.frmPrateleira(cbPrateleira);
            frm.ShowDialog();
        }

        private void frmAdicionarLivro_Load(object sender, EventArgs e)
        {
            lblAutorSelecionado.Text = "Selecione o(a) autorª";

            dgvAutores.DefaultCellStyle.ForeColor = Color.White;

            var es_Dao = new EstanteDAO();
            cbEstante.DataSource = es_Dao.ListarEstanteNoComboBox();
            cbEstante.DisplayMember = "Estante";
            cbEstante.ValueMember = "id_estante";
                        
            var pr_Dao = new PrateleiraDAO();
            cbPrateleira.DataSource = pr_Dao.ListarPrateleiraNoComboBox();
            cbPrateleira.DisplayMember = "Prateleira";
            cbPrateleira.ValueMember = "id_prateleira";

            var ge_Dao = new GeneroDAO();
            cbGenero.DataSource = ge_Dao.ListarGenero();
            cbGenero.DisplayMember = "Gênero";
            cbGenero.ValueMember = "Código";

            var ed_Dao = new EditoraDAO();
            cbEditora.DataSource = ed_Dao.ListarEditora();
            cbEditora.DisplayMember = "Editora";
            cbEditora.ValueMember = "Código";

            var au_Dao = new AutorDAO();
            dgvAutores.DataSource = au_Dao.ListarAutor();          
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {                        
            try
            {
                var obj = new Livro();
                obj.id_isbn = txtISBN.Text;
                obj.id_genero = int.Parse(cbGenero.SelectedValue.ToString());
                obj.id_estante = int.Parse(cbEstante.SelectedValue.ToString());
                obj.id_editora = int.Parse(cbEditora.SelectedValue.ToString());
                obj.id_prateleira = int.Parse(cbPrateleira.SelectedValue.ToString());
                
                obj.id_autor = int.Parse(dgvAutores.SelectedCells[0].Value.ToString());
                
                obj.Titulo = txtTitulo.Text;
                obj.CDD = txtCDD.Text;
                obj.Exemplar = txtExemplar.Text;
                obj.Volume = txtVolume.Text;
                obj.Status = true;
                obj.Status_Emprestimo = true;

                var dao = new LivroDAO();
                dao.CadastrarLivro(obj);

                this.Close();

                var utils = new Utils();
                utils.refreshInfoLivro(tabelaLivro, panelLivro);
                panelLivro.Controls.Clear();

                var frm = new frmLivros();
                frm.TopLevel = false;

                panelLivro.Controls.Add(tabelaLivro);
                frm.Show();
            }            
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar Livro");
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

        private void frmAdicionarLivro_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }       
    }
}