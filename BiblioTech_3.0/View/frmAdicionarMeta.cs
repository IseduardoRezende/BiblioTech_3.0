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
    public partial class frmAdicionarMeta : Form
    {       
        public frmAdicionarMeta()
        {
            InitializeComponent();           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Sair de Meta", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                this.Close();
            }
        }

        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "0")
            {
                txtTitulo.Text = "";
                txtTitulo.ForeColor = Color.White;
            }
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                txtTitulo.Text = "0";
                txtTitulo.ForeColor = Color.FromArgb(92, 92, 155);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = new Meta();
                obj.dta_inicio = cdpDataInicio.Value;
                obj.dta_encerramento = cdpFimPrazo.Value;
                obj.desc_meta = int.Parse(txtTitulo.Text);

                var dao = new MetaDAO();
                dao.AdicionarMeta(obj);

                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Apenas números são permitidos em Meta Atual.", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmAdicionarMeta_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        private void frmAdicionarMeta_Load(object sender, EventArgs e)
        {
            //if ()
            //{

            //}
        }
    }
}
