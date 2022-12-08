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
    public partial class frmUsuariosArquivados : Form
    {
        private Usuario UsuarioSelecionado;
        public frmUsuariosArquivados()
        {
            InitializeComponent();
        }

        private void frmUsuariosArquivados_Load(object sender, EventArgs e)
        {
            dgvUsuarioArquivado.DefaultCellStyle.ForeColor = Color.Black;

            UsuarioDAO dao = new UsuarioDAO();
            dgvUsuarioArquivado.DataSource = dao.ListarUsuarioArquivado();
        }

        private void dgvUsuarioArquivado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuario = new Usuario();
            usuario.id_usuario = int.Parse(dgvUsuarioArquivado.CurrentRow.Cells[0].Value.ToString());
            usuario.Nome = dgvUsuarioArquivado.CurrentRow.Cells[1].Value.ToString();
            usuario.Email = dgvUsuarioArquivado.CurrentRow.Cells[2].Value.ToString();
            usuario.Email_Opcional = dgvUsuarioArquivado.CurrentRow.Cells[3].Value.ToString();
            usuario.Telefone = dgvUsuarioArquivado.CurrentRow.Cells[4].Value.ToString();
            usuario.Telefone_Opcional = dgvUsuarioArquivado.CurrentRow.Cells[5].Value.ToString();

            lblEscolha.Text = $"Usuário selecionado: {usuario.Nome}";
            UsuarioSelecionado = usuario;
     
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(UsuarioSelecionado == null)
            {
                MessageBox.Show("Selecione um usuário");
                return;
            }
            var usuarioDAO = new UsuarioDAO();
            usuarioDAO.AlterarArquivado(UsuarioSelecionado.id_usuario, true);
            MessageBox.Show("Desarquivado com sucesso!");
            this.Close();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string nome = txtBusca.Text;

            var dao = new UsuarioDAO();
            dgvUsuarioArquivado.DataSource = dao.PesquisarUsuario(nome);

            if (dgvUsuarioArquivado.Rows.Count == 0)
            {
                MessageBox.Show("Usuário Arquivado não encontrado");
                dgvUsuarioArquivado.DataSource = dao.ListarUsuarioArquivado();
            }
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtBusca.Text + "%";
            
            var dao = new UsuarioDAO();
            dgvUsuarioArquivado.DataSource = dao.BuscarPorNome(nome);
        }       
    }
}