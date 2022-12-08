using BiblioTech_3._0.View;
using System.Windows.Forms;

namespace BiblioTech_3._0
{
    public partial class frmHome : Form
    {

        public frmHome()
        {
            InitializeComponent();
        }

        private void lklblMeta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmAdicionarMeta();
            frm.ShowDialog();
        }
    }
}
