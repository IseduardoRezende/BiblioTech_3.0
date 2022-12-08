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
    public partial class frmPrateleira : Form
    {
        int contador = 1;

        ComboBox box;

        DataGridView tabelaLivro;

        Panel panelLivro;

        public frmPrateleira(ComboBox box)
        {
            InitializeComponent();
            this.box = box;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarMaior_Click(object sender, EventArgs e)
        {
            lblNumero.Text = contador++.ToString();
            lblNumero.Refresh();
        }

        private void btnAdicionarMenor_Click(object sender, EventArgs e)
        {
            lblNumero.Text = contador--.ToString();
            lblNumero.Refresh();

            if (lblNumero.Text == "-1" && contador < 0)
            {
                MessageBox.Show("Apenas valores positivos");
                lblNumero.Text = "1";
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var obj = new Prateleira();
            obj.desc_prateleira = lblNumero.Text;

            var dao = new PrateleiraDAO();
            dao.AdicionarPrateleira(obj);

            this.Close();

            var utils = new Utils();
            utils.refreshInfoPrateleiraBox(box);

            var frm = new frmAdicionarLivro(tabelaLivro, panelLivro);
            frm.TopLevel = false;
            frm.Show();
        }

        private void frmPrateleira_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.BlueViolet, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
