using BiblioTech_3._0.CustomComponents;
using BiblioTech_3._0.DAO;
using BiblioTech_3._0.Model;
using BiblioTech_3._0.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech_3._0
{
    public partial class frmAdicionarEvento : Form
    {
        DataTable tabelaAddEvento;

        DataGridView tblAddEvento;
        
        Panel panelEvento;

        string tema;

        string descricao;

        CustomDatePicker dataEvento;

        public frmAdicionarEvento(DataTable dataTableEvento, Panel panel, DataGridView view, string tema, string descricao, CustomDatePicker dataEvento)
        {
            InitializeComponent();
            
            panelEvento = panel;           
            tblAddEvento = view;

            tabelaAddEvento = dataTableEvento;

            this.descricao = descricao;
            this.tema = tema;
            this.dataEvento = dataEvento;

            cdpEvento.CalendarTitleBackColor = Color.Red;
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtTema.Text == "Tema do evento:")
            {
                txtTema.Text = "";
            }
            else if (tema != null)
            {
                txtTema.Text = tema;
            }

            txtTema.ForeColor = Color.White;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtTema.Text == "")
            {
                txtTema.Text = "Tema do evento:";
                txtTema.ForeColor = Color.FromArgb(92, 92, 155);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja cancelar o cadastro do Evento", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {           
            //1 passo - cadastrar o evento

            var obj = new Evento();
            obj.Tema = txtTema.Text;
            obj.desc_evento = txtDescricao.Text;
            obj.data_evento = cdpEvento.Value;
            obj.Status = true;

            var dao = new EventoDAO();
            dao.CadastrarEvento(obj);

            //2 passo - retornar o id do ultimo evento
            
            int id = dao.retornaIdUltimoEvento();

            //3 passo - Salvar os participantes

            foreach (DataRow linha in tabelaAddEvento.Rows)
            {
                var participante = new UsuarioEvento();
                participante.id_evento = id;
                participante.id_usuario = int.Parse(linha["Código"].ToString());

                var dao_Evento = new UsuarioEventoDAO();
                dao_Evento.AdicionarParticipante(participante);
            }

            MessageBox.Show("Evento cadastrado com Sucesso !");

            this.Close();

            var utils = new Utils();
            utils.refreshInfoEvento(tblAddEvento, panelEvento);
            panelEvento.Controls.Clear();

            var frm = new frmEventos();
            frm.TopLevel = false;

            panelEvento.Controls.Add(tblAddEvento);
            frm.Show();            
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Título do Evento:";
                txtDescricao.ForeColor = Color.FromArgb(92, 92, 155);
            }
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "Título do Evento:")
            {
                txtDescricao.Text = "";
            }

            txtDescricao.ForeColor = Color.White;
        }
                
        private void frmAdicionarEvento_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            var frm = new frmAdicionarParticipante(tblAddEvento, panelEvento, txtTema.Text, txtDescricao.Text, cdpEvento);           
            frm.ShowDialog();
                       
            this.Hide();
        }

        private void frmAdicionarEvento_Load(object sender, EventArgs e)
        {
            dgvAdicionarParticipantes.DefaultCellStyle.ForeColor = Color.White;
            dgvAdicionarParticipantes.DataSource = tabelaAddEvento;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvAdicionarParticipantes);
        
            if(tema != null && descricao != null && dataEvento != null)
            {
                txtTema.Text = tema;
                txtDescricao.Text = descricao;
                cdpEvento.Value = DateTime.Parse(dataEvento.Value.ToString());
            }                        
        }
    }
}
