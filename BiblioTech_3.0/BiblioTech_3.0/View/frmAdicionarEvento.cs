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

namespace BiblioTech_3._0
{
    public partial class frmAdicionarEvento : Form
    {
        public frmAdicionarEvento()
        {
            InitializeComponent();
            dtpEvento.CalendarTitleBackColor = Color.Red;
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtTema.Text == "nome do usuario:")
            {
                txtTema.Text = "";
            }

            txtTema.ForeColor = Color.White;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtTema.Text == "")
            {
                txtTema.Text = "nome do usuario:";
                txtTema.ForeColor = Color.FromArgb(92, 92, 155);
            }
        }      

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var obj = new Evento();
            obj.Tema = txtTema.Text;
            obj.desc_evento = txtParticipantes.Text;
            obj.data_evento = dtpEvento.Value;

            var dao = new EventoDAO();
            dao.CadastrarEvento(obj);

            this.Close();
        }

        private void txtParticipantes_Enter(object sender, EventArgs e)
        {
            if (txtParticipantes.Text == "nome dos participantes:")
            {
                txtParticipantes.Text = "";
            }

            txtParticipantes.ForeColor = Color.White;
        }

        private void txtParticipantes_Leave(object sender, EventArgs e)
        {
            if (txtParticipantes.Text == "")
            {
                txtParticipantes.Text = "nome dos participantes:";
                txtParticipantes.ForeColor = Color.FromArgb(92, 92, 155);
            }
        }
    }
}
