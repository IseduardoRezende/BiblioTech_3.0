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
    public partial class frmAdicionarEditora : Form
    {
        DataGridView tabelaEditora;

        ComboBox box;

        Panel panelEditora;

        public frmAdicionarEditora(DataGridView view, Panel panel)
        {
            InitializeComponent();

            tabelaEditora = view;
            panelEditora = panel;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja cancelar o cadastro da editora", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();

            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome da Editora:")
            {
                txtNome.Text = "";
            }

            txtNome.ForeColor = Color.White;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome da Editora:";
                txtNome.ForeColor = Color.FromArgb(92, 92, 155);
            }            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var obj = new Editora();
            obj.desc_editora = txtNome.Text;

            var dao = new EditoraDAO();
            dao.CadastrarEditora(obj);

            this.Close();

            var utils = new Utils();
            utils.refreshInfoEditora(tabelaEditora, panelEditora);
            panelEditora.Controls.Clear();
            
            var frm = new frmEditora(box);
            frm.TopLevel = false;
            
            panelEditora.Controls.Add(tabelaEditora);
            frm.Show();
        }

        private void frmAdicionarEditora_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
