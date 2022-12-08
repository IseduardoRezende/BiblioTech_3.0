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
    public partial class frmAdicionarAutor : Form
    {
        DataGridView tabelaAutor;

        Panel panelAutor;

        public frmAdicionarAutor(DataGridView view, Panel panel)
        {
            InitializeComponent();
            tabelaAutor = view;
            panelAutor = panel;
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja cancelar o cadastro do autor", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            var obj = new Autor();
            obj.Nome_Autor = txtNome.Text;

            var dao = new AutorDAO();
            dao.AdicionarAutor(obj);
            
            this.Close();

            var utils = new Utils();
            utils.refreshInfoAutor(tabelaAutor, panelAutor);

            panelAutor.Controls.Clear();
            var frm = new frmAutor(tabelaAutor, panelAutor);
            frm.TopLevel = false;
            panelAutor.Controls.Add(tabelaAutor);
            frm.Show();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome do Autor:")
            {
                txtNome.Text = "";
            }
            txtNome.ForeColor = Color.White;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome do Autor:";
                txtNome.ForeColor = Color.FromArgb(92, 92, 155);
            }
        }
     
        private void frmAdicionarAutor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
