using BiblioTech_3._0.DAO;
using BiblioTech_3._0.Model;
using BiblioTech_3._0.VisualFunctions;
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
    public partial class frmAlterarUsuario : Form
    {
        TextBoxvisual styleTxt = new TextBoxvisual();

        private readonly Usuario usuario;

        Form FRMpai;

        DataGridView tabelaFRMpai;
        
        Panel panelFRMpai;

        string usuNome, usuEmail, usuEmail2, usuTelefone, usuTelefone2;
        Boolean usuStatus;

        #region Primeiro Click
        //função para verificar se é a primeira alteração em um txt

        Boolean primeiroclick = false;
        Boolean primeiraalteracao = false;

        public void ClickEntrada()
        {
            primeiroclick = true;
            primeiraalteracao = false;
        }

        public void PrimeiroClicktxt()
        {
            if (primeiroclick == true)
            {
                primeiroclick = false;
            }
            else
            {
                primeiraalteracao = true;
            }

        }
        #endregion



        public frmAlterarUsuario(Usuario usuario, DataGridView view, Panel panel, Form form)
        {
            InitializeComponent();
            this.usuario = usuario;
            usuNome = usuario.Nome;
            usuEmail = usuario.Email;
            usuEmail2 = usuario.Email_Opcional;
            usuTelefone = usuario.Telefone;
            usuTelefone2 = usuario.Telefone_Opcional;
            usuStatus = usuario.Status;

            txtNome.Text = usuNome;
            txtEmail.Text = usuEmail;
            txtEmail_Opcional.Text = usuEmail2;
            txtTelefone.Text = usuTelefone;
            txtTelefone_Opcional.Text = usuTelefone2;

            FRMpai = form;
            tabelaFRMpai = view;
            panelFRMpai = panel;
        }

        #region Nome

        private void TxtNome_Enter(object sender, EventArgs e)
        {
            ClickEntrada();
            styleTxt.TextBox_Enter(txtNome, lblBordaNome);
            usuNome = txtNome.Text;
            txtNome.Text = "";
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            PrimeiroClicktxt();
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "" && primeiraalteracao == false)
            {
                styleTxt.TextBoxDontChange_Leave(txtNome, lblBordaNome, usuNome);
            }
            else if (txtNome.Text == "" && primeiraalteracao == true)
            {
                styleTxt.TextBoxInvalid_Leave(txtNome, lblBordaNome);
            }
            else
            {
                styleTxt.TextBoxComplete_Leave(lblBordaNome);
            }
            usuNome = txtNome.Text;
        }
        #endregion

        #region Email

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            ClickEntrada();
            styleTxt.TextBox_Enter(txtEmail, lblBordaEmail);
            usuEmail = txtEmail.Text;
            txtEmail.Text = "";
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            PrimeiroClicktxt();
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" && primeiraalteracao == false)
            {
                styleTxt.TextBoxDontChange_Leave(txtEmail, lblBordaEmail, usuEmail);
            }
            else if (txtEmail.Text == "" && primeiraalteracao == true)
            {
                styleTxt.TextBoxInvalid_Leave(txtEmail, lblBordaEmail);
            }
            else
            {
                styleTxt.TextBoxComplete_Leave(lblBordaEmail);
            }
            usuario.Email = txtEmail.Text;
        }

        #endregion

        #region Telefone

        private void TxtTelefone_Enter(object sender, EventArgs e)
        {
            ClickEntrada();
            styleTxt.MaskedTextBox_Enter(txtTelefone, lblBordaTelefone);
            usuTelefone = txtTelefone.Text;
            txtTelefone.Text = "";
        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            PrimeiroClicktxt();
        }

        private void TxtTelefone_Leave(object sender, EventArgs e)
        {
            if (!txtTelefone.MaskFull && primeiroclick == false)
            {
                styleTxt.MaskedTextBoxDontChange_Leave(txtTelefone, lblBordaTelefone, usuTelefone);
            }
            else if (!txtTelefone.MaskCompleted && primeiroclick == true)
            {
                styleTxt.MaskedTextBoxInvalid_Leave(txtTelefone, lblBordaTelefone);
            }
            else
            {
                styleTxt.TextBoxComplete_Leave(lblBordaTelefone);
            }
            usuario.Telefone = txtTelefone.Text;
        }

        #endregion

        #region Email Opcional

        private void TxtEmail_Opcional_Enter(object sender, EventArgs e)
        {
            ClickEntrada();
            styleTxt.TextBox_Enter(txtEmail_Opcional, lblBordaEmail2);
            usuEmail2 = txtEmail_Opcional.Text;
            txtEmail_Opcional.Text = "";
        }
        private void txtEmail_Opcional_TextChanged(object sender, EventArgs e)
        {
            PrimeiroClicktxt();
        }

        private void TxtEmail_Opcional_Leave(object sender, EventArgs e)
        {
            if (txtEmail_Opcional.Text == "" && primeiraalteracao == false)
            {
                styleTxt.TextBoxIncomplete_Leave(txtEmail_Opcional, lblBordaEmail2, usuEmail2);
            }
            else if (txtEmail_Opcional.Text == "" && primeiraalteracao == true)
            {
                styleTxt.TextBoxIncomplete_Leave(txtEmail_Opcional, lblBordaEmail2, "");
            }
            else
            {
                styleTxt.TextBoxComplete_Leave(lblBordaEmail2);
            }
            usuario.Email_Opcional = txtEmail_Opcional.Text;
        }

#endregion

        #region Telefone Opcional

        private void TxtTelefone_Opcional_Enter(object sender, EventArgs e)
        {
            ClickEntrada();
            usuario.Telefone_Opcional = txtTelefone_Opcional.Text;
            txtTelefone_Opcional.Text = "";
            styleTxt.MaskedTextBox_Enter(txtTelefone_Opcional, lblBordaTelefone2);
        }
        private void txtTelefone_Opcional_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            PrimeiroClicktxt();
        }

        private void TxtTelefone_Opcional_Leave(object sender, EventArgs e)
        {
            if (!txtTelefone_Opcional.MaskFull && primeiraalteracao == false)
            {
                styleTxt.MaskedTextBoxIncomplete_Leave(txtTelefone_Opcional, lblBordaTelefone2, usuTelefone2);
            }
            else if (!txtTelefone_Opcional.MaskFull && primeiraalteracao == true)
            {
                styleTxt.MaskedTextBoxIncomplete_Leave(txtTelefone_Opcional, lblBordaTelefone2, "");
            }
            else
            {
                styleTxt.TextBoxComplete_Leave(lblBordaTelefone2);
            }
            usuario.Telefone_Opcional = txtTelefone_Opcional.Text;
        }
        #endregion

        private void Arquivar(object sender, EventArgs e)
        {       
            
            if (!usuStatus)
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja desarquivar este Usuário", "DESARQUIVAR USUÁRIO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                {
                    btnArquivar.Text = "ARQUIVAR USUÁRIO";
                    usuStatus = true;
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja arquivar este Usuário", "ARQUIVAR USUÁRIO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                {
                    btnArquivar.Text = "DESARQUIVAR USUÁRIO";
                    usuStatus = false;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja cancelar a alteração do Usuário", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                btnEditar.Visible = true;
                btnSair.Visible = true;
                btnArquivar.Visible = false;
                btnConfirmar.Visible = false;
                btnCancelar.Visible = false;

                usuNome = usuario.Nome;
                usuEmail = usuario.Email;
                usuEmail2 = usuario.Email_Opcional;
                usuTelefone = usuario.Telefone;
                usuTelefone2 = usuario.Telefone_Opcional;

                txtNome.Text = usuNome;
                txtEmail.Text = usuEmail;
                txtEmail_Opcional.Text = usuEmail2;
                txtTelefone.Text = usuTelefone;
                txtTelefone_Opcional.Text = usuTelefone2;
                if (usuStatus)
                {
                    btnArquivar.Text = "ARQUIVAR USUÁRIO";
                }
                else
                {
                    btnArquivar.Text = "DESARQUIVAR USUÁRIO";
                }

                foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        x.BackColor = Color.FromArgb(215, 215, 223);
                        x.ForeColor = Color.FromArgb(19, 18, 49);
                        x.Enabled = false;
                    }
                    if (x is MaskedTextBox)
                    {
                        x.BackColor = Color.FromArgb(215, 215, 223);
                        x.ForeColor = Color.FromArgb(19, 18, 49);
                        x.Enabled = false;
                    }
                    if (x is Label)
                    {
                        if (x.BackColor != Color.Transparent)
                        {
                            x.BackColor = Color.FromArgb(192, 192, 255);
                        }
                    }
                }
            }
        }

        private void frmAlterarUsuario_Load(object sender, EventArgs e)
        {
            if (usuStatus)
            {
                btnArquivar.Text = "ARQUIVAR USUÁRIO";
            }
            else
            {
                btnArquivar.Text = "DESARQUIVAR USUÁRIO";
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja salvar estas alterações do Usuário", "Salvar Alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                if (usuNome == "")
                {
                    MessageBox.Show("O usuário precisa possuir um nome.");
                }
                if (usuEmail == "" && usuEmail2 == "")
                {
                    MessageBox.Show("O usuário precisa possuir um email.");
                }
                else if (usuEmail == "" && usuEmail2 != "")
                {
                    usuEmail = usuEmail2;
                    txtEmail.Text = usuEmail;
                    usuEmail2 = "";
                    txtEmail_Opcional.Text = usuEmail2;

                }
                if (usuTelefone == "" && usuTelefone2 != "")
                {
                    MessageBox.Show("O usuário precisa possuir um telefone.");
                }
                else if (usuTelefone == "" && usuTelefone2 != "")
                {
                    usuTelefone = usuTelefone2;
                    txtTelefone.Text = usuTelefone;
                    usuTelefone2 = "";
                    txtTelefone_Opcional.Text = "";
                }
                if (usuNome != "" && usuEmail != "" && usuTelefone != "")
                {
                    usuario.Nome = usuNome;
                    usuario.Email = usuEmail;
                    usuario.Email_Opcional = usuEmail2;
                    usuario.Telefone = usuTelefone;
                    usuario.Telefone_Opcional = usuTelefone2;
                    usuario.Status = usuStatus;
                    UsuarioDAO dao = new UsuarioDAO();
                    dao.AlterarUsuario(usuario);
                }
                btnEditar.Visible = true;
                btnSair.Visible = true;
                btnArquivar.Visible = false;
                btnConfirmar.Visible = false;
                btnCancelar.Visible = false;

                usuNome = usuario.Nome;
                usuEmail = usuario.Email;
                usuEmail2 = usuario.Email_Opcional;
                usuTelefone = usuario.Telefone;
                usuTelefone2 = usuario.Telefone_Opcional;

                txtNome.Text = usuNome;
                txtEmail.Text = usuEmail;
                txtEmail_Opcional.Text = usuEmail2;
                txtTelefone.Text = usuTelefone;
                txtTelefone_Opcional.Text = usuTelefone2;
                if (!usuStatus)
                {
                    btnArquivar.Text = "ARQUIVAR USUÁRIO";
                }
                else
                {
                    btnArquivar.Text = "DESARQUIVAR USUÁRIO";
                }

                foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        x.BackColor = Color.FromArgb(215, 215, 223);
                        x.ForeColor = Color.FromArgb(19, 18, 49);
                        x.Enabled = false;
                    }
                    if (x is MaskedTextBox)
                    {
                        x.BackColor = Color.FromArgb(215, 215, 223);
                        x.ForeColor = Color.FromArgb(19, 18, 49);
                        x.Enabled = false;
                    }
                    if (x is Label)
                    {
                        if (x.BackColor != Color.Transparent)
                        {
                            x.BackColor = Color.FromArgb(192, 192, 255);
                        }
                    }
                }
            }
        }

        private void frmAlterarUsuario_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            var utils = new Utils();
            if (FRMpai is frmUsuariosArquivados){
                utils.refreshInfoUsuario(tabelaFRMpai, panelFRMpai, true);
            }
            else
            {
                utils.refreshInfoUsuario(tabelaFRMpai, panelFRMpai, false);
            }
            panelFRMpai.Controls.Clear();
            panelFRMpai.Controls.Add(tabelaFRMpai);
            FRMpai.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = false;
            btnSair.Visible = false;
            btnArquivar.Visible = true;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    x.BackColor = Color.FromArgb(49, 48, 79);
                    x.ForeColor = Color.FromArgb(92, 92, 155);
                    x.Enabled = true;
                }
                if (x is MaskedTextBox)
                {
                    x.BackColor = Color.FromArgb(49, 48, 79);
                    x.ForeColor = Color.FromArgb(92, 92, 155);
                    x.Enabled = true;
                }
                if (x is Label)
                {
                    if (x.BackColor != Color.Transparent)
                    {
                        x.BackColor = Color.FromArgb(49, 48, 79);
                    }
                }
            }
        }
    }
}
