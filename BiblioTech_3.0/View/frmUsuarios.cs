using BiblioTech_3._0.DAO;
using BiblioTech_3._0.Model;
using BiblioTech_3._0.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BiblioTech_3._0
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuario addUsuario = new frmAdicionarUsuario(dgvUsuario, pnlUsuario);
            addUsuario.ShowDialog();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuario.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvUsuario);
            

            UsuarioDAO dao = new UsuarioDAO();
            dgvUsuario.DataSource = dao.ListarUsuario();
        }

        private void BtnArquivo_Click(object sender, EventArgs e)
        {
            frmUsuariosArquivados frm = new View.frmUsuariosArquivados(dgvUsuario, pnlUsuario);
            frm.ShowDialog();
        }

        private void DgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuario = new Usuario();
            usuario.id_usuario = int.Parse(dgvUsuario.CurrentRow.Cells[0].Value.ToString());
            usuario.Nome = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
            usuario.Email = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
            usuario.Email_Opcional = dgvUsuario.CurrentRow.Cells[3].Value.ToString();
            usuario.Telefone = dgvUsuario.CurrentRow.Cells[4].Value.ToString();
            usuario.Telefone_Opcional = dgvUsuario.CurrentRow.Cells[5].Value.ToString();
            usuario.Status = (bool)dgvUsuario.CurrentRow.Cells[6].Value;

            var alterar = new frmAlterarUsuario(usuario, dgvUsuario, pnlUsuario, this);
            alterar.Show();
        }

        private void BtnBusca_Click(object sender, EventArgs e)
        {
            string nome = txtBusca.Text;

            UsuarioDAO dao = new UsuarioDAO();

            dgvUsuario.DataSource = dao.PesquisarUsuario(nome);

            if (dgvUsuario.Rows.Count == 0)
            {
                MessageBox.Show("Usuario não encontrado");
                dgvUsuario.DataSource = dao.ListarUsuario();

                txtBusca.Text = string.Empty;
            }
        }

        private void TxtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtBusca.Text + "%";
            UsuarioDAO dao = new UsuarioDAO();

            dgvUsuario.DataSource = dao.BuscarPorNome(nome);
        }

        //private void txtBusca_TextChanged(object sender, EventArgs e)
        //{
        //    string nome = txtBusca.Text;

        //    UsuarioDAO dao = new UsuarioDAO();

        //    dgvUsuario.DataSource = dao.PesquisarUsuario(nome);
        //}
    }
}