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
    public partial class frmAlterarEmprestimo : Form
    {
        DataTable tabelaEmprestimo;

        Panel panelEmprestimo;

        Livro livro;

        DataGridView gridEmprestimo;

        Emprestimo emprestimo;

        public frmAlterarEmprestimo(DataTable dataTable, Panel panel, DataGridView view, Livro livro, Emprestimo emprestimo)
        {
            InitializeComponent();

            tabelaEmprestimo = dataTable;
            panelEmprestimo = panel;
            gridEmprestimo = view;

            this.livro = livro;
            txtISBN.Text = livro.id_isbn;
            txtTitulo.Text = livro.Titulo;

            this.emprestimo = emprestimo;
            cdpDataEntrega.Value = emprestimo.dta_entrega;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Cancelar alteração", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                this.Close();
            }
        }

        private void frmAlterarEmprestimo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        private void frmAlterarEmprestimo_Load(object sender, EventArgs e)
        {
            dgvUsuarioEmprestimo.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvUsuarioEmprestimo);

            var dao = new EmprestimoDAO();
            dgvUsuarioEmprestimo.DataSource = dao.ListarUsuarioEmprestimo(emprestimo.id_emprestimo);
        }

        private void btnGerenciarUsuario_Click(object sender, EventArgs e)
        {
            var frm = new frmAdicionarUsuarioEmprestimo(livro, dgvUsuarioEmprestimo, pnlUsuario, cdpDataEntrega);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {            
            emprestimo.id_usuario = int.Parse(dgvUsuarioEmprestimo.CurrentRow.Cells[0].Value.ToString());
            emprestimo.dta_entrega = cdpDataEntrega.Value;

            var dao = new EmprestimoDAO();
            dao.AlterarEmprestimo(emprestimo);

            var utils = new Utils();
            utils.refreshInfoEmprestimo(gridEmprestimo, panelEmprestimo);
            panelEmprestimo.Controls.Clear();

            var frm = new frmEmprestimos();
            frm.TopLevel = false;

            panelEmprestimo.Controls.Add(gridEmprestimo);
            frm.Show();

            this.Close();
        }
    }
}
