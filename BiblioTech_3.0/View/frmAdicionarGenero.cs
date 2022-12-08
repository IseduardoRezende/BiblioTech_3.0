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
    public partial class frmAdicionarGenero : Form
    {
        DataGridView tabelaGenero;

        ComboBox box;

        Panel panelGenero;

        public frmAdicionarGenero(DataGridView view, Panel panel)
        {
            InitializeComponent();
            tabelaGenero = view;
            panelGenero = panel;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja cancelar o cadastro de Gênero", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }
     
        private void txtGenero_Enter(object sender, EventArgs e)
        {
            if (txtGenero.Text == "Gênero:")
            {
                txtGenero.Text = "";
                txtGenero.ForeColor = Color.White;
            }
        }

        private void txtGenero_Leave(object sender, EventArgs e)
        {
            if (txtGenero.Text == "")
            {
                txtGenero.Text = "Gênero:";
                txtGenero.ForeColor = Color.FromArgb(92, 92, 155);
            }
        }
          
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var obj = new Genero();
            obj.Nome_Genero = txtGenero.Text;

            var dao = new GeneroDAO();
            dao.AdicionarGenero(obj);

            Close();

            var utils = new Utils();

            utils.refreshInfoGenero(tabelaGenero, panelGenero);
            panelGenero.Controls.Clear();

            var frm = new frmGenero(box);
            
            frm.TopLevel = false;
            panelGenero.Controls.Add(tabelaGenero);
            frm.Show();
        }

        private void frmAdicionarGenero_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
