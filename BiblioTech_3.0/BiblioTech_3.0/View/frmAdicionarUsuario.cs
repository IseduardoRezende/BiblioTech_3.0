using BiblioTech_3._0.DAO;
using BiblioTech_3._0.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BiblioTech_3._0
{
    public partial class frmAdicionarUsuario : Form
    {
        public frmAdicionarUsuario()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();
            obj.Nome = txtNome.Text;
            obj.Email = txtEmail.Text;
            obj.Email_Opcional = txtEmail_Opcional.Text;
            obj.Telefone = txtTelefone.Text;
            obj.Telefone_Opcional = txtTelefone_Opcional.Text;
            obj.Status = true;

            UsuarioDAO dao = new UsuarioDAO();
            dao.CadastrarUsuario(obj);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja cancelar o cadastro ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                new Helpier().LimparTela(this);
            }
        }

        private void TxtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome do Usuario:")
            {
                txtNome.Text = "";
                lblNome.Visible = true;
            }
            lblBordaNome.BackColor = Color.FromArgb(92, 92, 155);
            txtNome.ForeColor = Color.White;
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome do Usuario:";
                lblNome.Visible = false;
                lblBordaNome.BackColor = Color.FromArgb(49, 48, 79);
                txtNome.ForeColor = Color.FromArgb(92, 92, 155);
            }
            else
            {
                lblBordaNome.BackColor = Color.FromArgb(92, 92, 155);
            }
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "emaildousuario@gmial.com")
            {
                txtEmail.Text = "";
                lblEmail.Visible = true;
            }
            lblBordaEmail.BackColor = Color.FromArgb(192, 192, 255);
            txtEmail.ForeColor = Color.White;
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "emaildousuario@gmial.com";
                lblEmail.Visible = false;
                lblBordaEmail.BackColor = Color.FromArgb(49, 48, 79);
                txtEmail.ForeColor = Color.FromArgb(92, 92, 155);
            }
            else
            {
                lblBordaEmail.BackColor = Color.FromArgb(92, 92, 155);
            }
        }

        private void TxtTelefone_Enter(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "11 90000-0000")
            {
                txtTelefone.Text = "11 9";
                lblTelefone.Visible = true;
            }
            lblBordaTelefone.BackColor = Color.FromArgb(192, 192, 255);
            txtTelefone.ForeColor = Color.White;
        }

        private void TxtTelefone_Leave(object sender, EventArgs e)
        {
            if (!txtTelefone.MaskFull)
            {
                txtTelefone.Text = "11 90000-0000";
                lblTelefone.Visible = false;
                lblBordaTelefone.BackColor = Color.FromArgb(49, 48, 79);
                txtTelefone.ForeColor = Color.FromArgb(92, 92, 155);
            }
            else if (txtTelefone.Text == "11 90000-0000")
            {
                txtTelefone.ForeColor = Color.FromArgb(92, 92, 155);
            }
            else if (txtTelefone.MaskCompleted)
            {
                lblBordaTelefone.BackColor = Color.FromArgb(92, 92, 155);
                txtTelefone.ForeColor = Color.White;
            }
        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {
            pnlEmail2.Visible = true;
            btnexibirEmail2.Visible = false;
            txtEmail_Opcional.Text = "email2dousuario@gmail.com";
        }

        private void BtnTelefone2_Click(object sender, EventArgs e)
        {
            pnlTelefone2.Visible = true;
            btnexibirTelefone2.Visible = false;
            txtTelefone_Opcional.Text = "11 90000-0000";
        }

        private void BtnOcultarEmail2_Click(object sender, EventArgs e)
        {
            pnlEmail2.Visible = false;
            btnexibirEmail2.Visible = true;
            txtEmail_Opcional.Text = "";
        }

        private void BtnOcultarTelefone2_Click(object sender, EventArgs e)
        {
            pnlTelefone2.Visible = false;
            btnexibirTelefone2.Visible = true;
            txtTelefone_Opcional.Text = "";
        }

        private void TxtEmail2_Enter(object sender, EventArgs e)
        {
            if (txtEmail_Opcional.Text == "email2dousuario@gmail.com")
            {
                txtEmail_Opcional.Text = "";
                lblEmail2.Visible = true;
            }
            lblBordaEmail2.BackColor = Color.FromArgb(192, 192, 255);
            txtEmail_Opcional.ForeColor = Color.White;
        }

        private void TxtEmail2_Leave(object sender, EventArgs e)
        {
            if (txtEmail_Opcional.Text == "")
            {
                txtEmail_Opcional.Text = "email2dousuario@gmail.com";
                lblEmail2.Visible = false;
                lblBordaEmail2.BackColor = Color.FromArgb(49, 48, 79);
                txtEmail_Opcional.ForeColor = Color.FromArgb(92, 92, 155);
            }
            else
            {
                lblBordaEmail2.BackColor = Color.FromArgb(92, 92, 155);
            }
        }

        private void TxtTelefone2_Enter(object sender, EventArgs e)
        {
            if (txtTelefone_Opcional.Text == "11 90000-0000")
            {
                txtTelefone_Opcional.Text = "11 9";
                lblTelefone2.Visible = true;
            }
            lblBordaTelefone2.BackColor = Color.FromArgb(192, 192, 255);
            txtTelefone_Opcional.ForeColor = Color.White;
        }

        private void TxtTelefone2_Leave(object sender, EventArgs e)
        {
            if (!txtTelefone_Opcional.MaskFull)
            {
                txtTelefone_Opcional.Text = "11 90000-0000";
                lblTelefone2.Visible = false;
                lblBordaTelefone2.BackColor = Color.FromArgb(49, 48, 79);
                txtTelefone_Opcional.ForeColor = Color.FromArgb(92, 92, 155);
            }
            else if (txtTelefone_Opcional.Text == "11 90000-0000")
            {
                txtTelefone_Opcional.ForeColor = Color.FromArgb(92, 92, 155);
            }
            else if (txtTelefone_Opcional.MaskCompleted)
            {
                lblBordaTelefone2.BackColor = Color.FromArgb(92, 92, 155);
                txtTelefone_Opcional.ForeColor = Color.White;
            }
        }       
    }
}
