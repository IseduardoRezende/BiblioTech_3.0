using BiblioTech_3._0.CustomComponents;
using BiblioTech_3._0.DAO;
using BiblioTech_3._0.Model;
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

namespace BiblioTech_3._0.View
{
    public partial class frmAlterarEvento : Form
    {
        private readonly Evento evento;
        
        public int id_evento;

        DataGridView tabelaAlterarEvento;

        Panel panelAlterar;

        Usuario ParticipanteSelecionado;

        DataTable linhaSelecionada;

        private List<int> ParticipantesRemovidos;

        int indiceParaRemocaoSelecionado;

        string descricao;

        string tema;

        CustomDatePicker dataEvento;

        public frmAlterarEvento(Evento evento, DataGridView view, Panel panel, DataTable table, string descricao, string tema, CustomDatePicker dataEvento)
        {
            InitializeComponent();

            this.evento = evento;
            id_evento = int.Parse(evento.id_evento.ToString());
            txtTema.Text = evento.Tema;
            txtDescricao.Text = evento.desc_evento;
            cdpEvento.Value = evento.data_evento;

            tabelaAlterarEvento = view;
            panelAlterar = panel;

            linhaSelecionada = table;          

            ParticipantesRemovidos = new List<int>();

            this.descricao = descricao;
            this.tema = tema;
            this.dataEvento = dataEvento;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
             if (DialogResult.Yes == MessageBox.Show("Deseja cancelar a alteração do Evento", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question))               
             {
                this.Close();
             }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            evento.Tema = txtTema.Text;
            evento.desc_evento = txtDescricao.Text;
            evento.data_evento = cdpEvento.Value;

            var dao = new EventoDAO();
            dao.AlterarEvento(evento);           

            MessageBox.Show("Evento alterado com sucesso !");

            this.Close();

            var utils = new Utils();
            utils.refreshInfoEvento(tabelaAlterarEvento, panelAlterar);
            panelAlterar.Controls.Clear();

            var frm = new frmEventos();
            frm.TopLevel = false;

            panelAlterar.Controls.Add(tabelaAlterarEvento);
            frm.Show();
        }

        private void txtTema_Enter(object sender, EventArgs e)
        {
            if (txtTema.Text == "Tema do evento:")
            {
                txtTema.Text = "";
            }

            txtTema.ForeColor = Color.White;
        }

        private void txtTema_Leave(object sender, EventArgs e)
        {
            if (txtTema.Text == "")
            {
                txtTema.Text = "Tema do evento:";
                txtTema.ForeColor = Color.FromArgb(92, 92, 155);
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

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Título do Evento:";
                txtDescricao.ForeColor = Color.FromArgb(92, 92, 155);
            }
        }      

        private void frmAlterarEvento_Load(object sender, EventArgs e)
        {
            dgvAlterarParticipante.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvAlterarParticipante);

            var dao = new UsuarioEventoDAO();

            dgvAlterarParticipante.DataSource = dao.ListarParticipante(evento.id_evento);
        }

        private void btnAdicionarParticipantes_Click(object sender, EventArgs e)
        {
            var frm = new frmAlterarParticipante(evento.id_evento, evento, linhaSelecionada, tabelaAlterarEvento, panelAlterar, txtDescricao.Text, txtTema.Text, cdpEvento);
            this.Hide();

            frm.ShowDialog();
        }

        private void FrmAlterarEvento_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }     

        private void dgvAlterarParticipante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var participante = new Usuario();

            participante.id_usuario = int.Parse(dgvAlterarParticipante.CurrentRow.Cells[0].Value.ToString());
            participante.Nome = dgvAlterarParticipante.CurrentRow.Cells[1].Value.ToString();

            lblParticipanteSelecionado.Text = $"{participante.Nome} selecionadoª";

            this.indiceParaRemocaoSelecionado = e.RowIndex;
            this.ParticipanteSelecionado = participante;
        }

        private void btnRemoverParticipantes_Click(object sender, EventArgs e)
        {
            if (ParticipanteSelecionado == null)
            {
                MessageBox.Show("Nenhum participante selecionado para remoção");
                return;
            }
            else if (DialogResult.Yes == MessageBox.Show($"Deseja remover {ParticipanteSelecionado.Nome}", "Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    ParticipantesRemovidos.Add(ParticipanteSelecionado.id_usuario);
                    var linha = dgvAlterarParticipante.Rows[indiceParaRemocaoSelecionado];
                    dgvAlterarParticipante.Rows.Remove(linha);

                    foreach (var idSelecionado in ParticipantesRemovidos)
                    {
                        var participante = new UsuarioEvento();
                        participante.id_evento = evento.id_evento;
                        participante.id_usuario = idSelecionado;

                        var dao_Evento = new UsuarioEventoDAO();
                        dao_Evento.RemoverParticipante(participante);
                    }

                    MessageBox.Show("Participante removido com sucesso !");

                    lblParticipanteSelecionado.Text = string.Empty;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao remover participante", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }                
            }            
        }        
    }
}