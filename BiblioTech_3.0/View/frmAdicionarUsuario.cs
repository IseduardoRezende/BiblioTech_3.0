using BiblioTech_3._0.DAO;
using BiblioTech_3._0.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using BiblioTech_3._0.VisualFunctions;

namespace BiblioTech_3._0
{
    public partial class frmAdicionarUsuario : Form
    {
        DataGridView tabelaAddUsuario;
        
        Panel panelUsuario;

        TextBoxvisual styleTxt = new TextBoxvisual();
        
        public frmAdicionarUsuario(DataGridView view, Panel panel)
        {
            InitializeComponent();
            tabelaAddUsuario = view;
            panelUsuario = panel;
        }

        string
            msgNome = "Nome do Usuário",
            msgEmail = "emaildousuário@gmail.com",
            msgEmail2 = "emaildousuário2@gmail.com",
            msgTel = "11 90000-0000",
            msgTel2 = "11 90000-0000";

        private void frmAdicionarUsuario_Load(object sender, EventArgs e)
        {
            txtNome.Text = msgNome;
            txtEmail.Text = msgEmail;
            txtEmail_Opcional.Text = msgEmail2;
            txtTelefone.Text = msgTel;
            txtTelefone_Opcional.Text = msgTel2;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean dados = true;
                Usuario obj = new Usuario();
                if (txtNome.Text == "" || txtNome.Text == msgNome)
                {
                    MessageBox.Show("O usuário precisa possuir um nome.", "NÃO FOI POSSIVEL CADASTRAR O USUARIO", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    styleTxt.TextBoxInvalid_Leave(txtNome, lblBordaNome);
                    dados = false;
                }
                else
                {
                    obj.Nome = txtNome.Text;
                }
                if (txtEmail.Text == "" || txtEmail.Text == msgEmail)
                {
                    MessageBox.Show("O usuário precisa possuir um email.", "NÃO FOI POSSIVEL CADASTRAR O USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    styleTxt.TextBoxInvalid_Leave(txtEmail, lblBordaEmail);
                    dados = false;
                }
                else
                {
                    obj.Email = txtEmail.Text;
                }
                if (!txtTelefone.MaskCompleted || txtTelefone.Text == msgTel)
                {
                    MessageBox.Show("O usuário precisa possuir um telefone.", "NÃO FOI POSSIVEL CADASTRAR O USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    styleTxt.MaskedTextBoxInvalid_Leave(txtTelefone, lblBordaTelefone);
                    dados = false;
                }
                else
                {
                    obj.Telefone = txtTelefone.Text;
                }
                if (txtEmail_Opcional.Text == msgEmail2)
                {
                    obj.Email_Opcional = "";
                }
                else
                {
                    obj.Email_Opcional = txtEmail_Opcional.Text;
                }
                if (!txtTelefone_Opcional.MaskCompleted || txtTelefone_Opcional.Text == msgTel2)
                {
                    obj.Telefone_Opcional = "";
                }
                else
                {
                    obj.Telefone_Opcional = txtTelefone_Opcional.Text;
                }
                obj.Status = true;
                if (dados == true)
                {
                    UsuarioDAO dao = new UsuarioDAO();
                    dao.CadastrarUsuario(obj);
                    this.Close();

                    var utils = new Utils();

                    utils.refreshInfoUsuario(tabelaAddUsuario, panelUsuario, false);

                    panelUsuario.Controls.Clear();
                    var frm = new frmUsuarios();
                    frm.TopLevel = false;
                    panelUsuario.Controls.Add(tabelaAddUsuario);
                    frm.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não é possível cadastrar usuário");
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja cancelar o cadastro ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                this.Close();
            }
        }

        private void TxtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == msgNome)
            {
                txtNome.Text = "";
            }
            styleTxt.TextBox_Enter(txtNome, lblBordaNome);
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                styleTxt.TextBoxIncomplete_Leave(txtNome, lblBordaNome, msgNome);
            }
            else
            {
                styleTxt.TextBoxComplete_Leave(lblBordaNome);
            }
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == msgEmail)
            {
                txtEmail.Text = "";
            }
            styleTxt.TextBox_Enter(txtEmail, lblBordaEmail);
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                styleTxt.TextBoxIncomplete_Leave(txtEmail, lblBordaEmail, msgEmail);
            }
            else
            {
                styleTxt.TextBoxComplete_Leave(lblBordaEmail);
            }
        }

        private void TxtTelefone_Enter(object sender, EventArgs e)
        {
            if (txtTelefone.Text == msgTel)
            {
                txtTelefone.Text = "11 9";
            }
            styleTxt.MaskedTextBox_Enter(txtTelefone, lblBordaTelefone);
        }

        private void TxtTelefone_Leave(object sender, EventArgs e)
        {
            if (!txtTelefone.MaskFull)
            {
                styleTxt.MaskedTextBoxIncomplete_Leave(txtTelefone, lblBordaTelefone, msgTel);
            }
            else if (txtTelefone.Text == msgTel)
            {
                styleTxt.TextBoxComplete_Leave(lblBordaTelefone);
            }
            else if (txtTelefone.MaskCompleted)
            {
                styleTxt.TextBoxComplete_Leave(lblBordaTelefone);
            }
        }

        public void BtnEmail_Click(object sender, EventArgs e)
        {
            pnlEmail2.Visible = true;
            btnexibirEmail2.Visible = false;
            txtEmail_Opcional.Text = msgEmail2;
        }

        private void BtnTelefone2_Click(object sender, EventArgs e)
        {
            pnlTelefone2.Visible = true;
            btnexibirTelefone2.Visible = false;
            txtTelefone_Opcional.Text = msgTel2;
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
            if (txtEmail_Opcional.Text == msgEmail2)
            {
                txtEmail_Opcional.Text = "";
            }
            styleTxt.TextBox_Enter(txtEmail_Opcional, lblBordaEmail2);
        }

        private void TxtEmail2_Leave(object sender, EventArgs e)
        {
            if (txtEmail_Opcional.Text == "")
            {
                styleTxt.TextBoxIncomplete_Leave(txtEmail_Opcional, lblBordaEmail2, msgEmail2);
            }
            else
            {
                styleTxt.TextBoxComplete_Leave(lblBordaEmail2);
            }
        }

        private void TxtTelefone2_Enter(object sender, EventArgs e)
        {
            if (txtTelefone_Opcional.Text == msgTel)
            {
                txtTelefone_Opcional.Text = "11 9";
            }
            styleTxt.MaskedTextBox_Enter(txtTelefone_Opcional, lblBordaTelefone2);
        }

        private void TxtTelefone2_Leave(object sender, EventArgs e)
        {
            if (!txtTelefone_Opcional.MaskFull)
            {
                styleTxt.MaskedTextBoxIncomplete_Leave(txtTelefone_Opcional, lblBordaTelefone2, msgTel2);
            }
            else if (txtTelefone_Opcional.Text == msgTel)
            {
                styleTxt.TextBoxComplete_Leave(lblBordaTelefone2);
            }
            else if (txtTelefone_Opcional.MaskCompleted)
            {
                styleTxt.TextBoxComplete_Leave(lblBordaTelefone2);
            }
        }
        
        private void frmAdicionarUsuario_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
