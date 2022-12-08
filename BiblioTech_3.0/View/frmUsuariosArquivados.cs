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

        DataGridView tabelaUsuarioArquivado;
        
        Panel panelArquivado;

        public frmUsuariosArquivados(DataGridView view, Panel panel)
        {
            InitializeComponent();
            tabelaUsuarioArquivado = view;
            panelArquivado = panel;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            var utils = new Utils();

            utils.refreshInfoUsuario(tabelaUsuarioArquivado, panelArquivado, false);

            panelArquivado.Controls.Clear();

            frmUsuarios frm = new frmUsuarios();
            frm.TopLevel = false;

            panelArquivado.Controls.Add(tabelaUsuarioArquivado);
            frm.Show();
        }

        private void FrmUsuariosArquivados_Load(object sender, EventArgs e)
        {
            dgvUsuarioArquivado.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvUsuarioArquivado);

            UsuarioDAO dao = new UsuarioDAO();
            dgvUsuarioArquivado.DataSource = dao.ListarUsuarioArquivado();
        }       

        private void BtnDesarquivar_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado == null)
            {
                MessageBox.Show("Selecione um usuário");
                return;
            }
            var usuarioDAO = new UsuarioDAO();
            
            usuarioDAO.AlterarArquivado(UsuarioSelecionado.id_usuario, true);

            MessageBox.Show("Desarquivado com sucesso!");
        }

        private void BtnBusca_Click(object sender, EventArgs e)
        {
            string nome = txtBusca.Text;

            var dao = new UsuarioDAO();
            dgvUsuarioArquivado.DataSource = dao.PesquisarUsuarioArquivado(nome);

            if (dgvUsuarioArquivado.Rows.Count == 0)
            {
                MessageBox.Show("Usuário Arquivado não encontrado");
                dgvUsuarioArquivado.DataSource = dao.ListarUsuarioArquivado();

                txtBusca.Text = string.Empty;
            }
        }

        private void TxtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtBusca.Text + "%";

            var dao = new UsuarioDAO();
            dgvUsuarioArquivado.DataSource = dao.BuscarPorNomeArquivado(nome);
        }

        private void dgvUsuarioArquivado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuario = new Usuario();
            usuario.id_usuario = int.Parse(dgvUsuarioArquivado.CurrentRow.Cells[0].Value.ToString());
            usuario.Nome = dgvUsuarioArquivado.CurrentRow.Cells[1].Value.ToString();
            usuario.Email = dgvUsuarioArquivado.CurrentRow.Cells[2].Value.ToString();
            usuario.Email_Opcional = dgvUsuarioArquivado.CurrentRow.Cells[3].Value.ToString();
            usuario.Telefone = dgvUsuarioArquivado.CurrentRow.Cells[4].Value.ToString();
            usuario.Telefone_Opcional = dgvUsuarioArquivado.CurrentRow.Cells[5].Value.ToString();

            lblArquivado.Text = $"Usuário selecionado: {usuario.Nome}";
            UsuarioSelecionado = usuario;
        }

        private void frmUsuariosArquivados_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        private void dgvUsuarioArquivado_DoubleClick(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.id_usuario = int.Parse(dgvUsuarioArquivado.CurrentRow.Cells[0].Value.ToString());
            usuario.Nome = dgvUsuarioArquivado.CurrentRow.Cells[1].Value.ToString();
            usuario.Email = dgvUsuarioArquivado.CurrentRow.Cells[2].Value.ToString();
            usuario.Email_Opcional = dgvUsuarioArquivado.CurrentRow.Cells[3].Value.ToString();
            usuario.Telefone = dgvUsuarioArquivado.CurrentRow.Cells[4].Value.ToString();
            usuario.Telefone_Opcional = dgvUsuarioArquivado.CurrentRow.Cells[5].Value.ToString();
            usuario.Status = (bool)dgvUsuarioArquivado.CurrentRow.Cells[6].Value;

            var alterar = new frmAlterarUsuario(usuario, dgvUsuarioArquivado, pnlUsuariosArquivados, this);
            alterar.Show();
        }
    }
}
