using BiblioTech_3._0.CustomComponents;
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
    public partial class frmMeta : Form
    {
        Meta obj = new Meta();

        DateTime dataInicio;

        DateTime dataFim;

        public frmMeta()
        {
            InitializeComponent();

            txtTitulo.Text = obj.desc_meta.ToString();
            cdpInicioPrazo.MinDate = obj.dta_inicio;
            cdpFimPrazo.MinDate = obj.dta_encerramento;
        }

        private void frmMeta_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Sair de Metas", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                this.Close();
            }
        }

        private void frmMeta_Load(object sender, EventArgs e)
        {
            dgvEmprestimo.DefaultCellStyle.ForeColor = Color.White;

            var layout = new Layout();
            layout.DataGridViewLayout(dgvEmprestimo);

            var dao = new MetaDAO();

            int id = dao.RetornaUltimaMeta();

            obj = dao.RetornaDadosMetaId(id);

            //Exibindo dados nos componentes:

            if (obj == null)
            {
                MessageBox.Show("Nenhuma Meta existente");

                if (DialogResult.Yes == MessageBox.Show("Deseja criar uma meta ?", "Adicionar Meta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    var frm = new frmAdicionarMeta();
                    frm.ShowDialog();

                    Close();
                }
                else
                {
                    Close();
                }
            }
            else if (obj != null)
            {
                btnAdicionar.Visible = false;

                txtTitulo.Text = obj.desc_meta.ToString();
                cdpInicioPrazo.Value = obj.dta_inicio;
                cdpFimPrazo.Value = obj.dta_encerramento;

                dataInicio = DateTime.Parse(cdpInicioPrazo.Value.ToString("yyyy-MM-dd"));
                dataFim = DateTime.Parse(cdpFimPrazo.Value.ToString("yyyy-MM-dd"));

                dgvEmprestimo.DataSource = dao.ListarEmprestimoPorPeriodo(dataInicio, dataFim);

                lblTabelasAtuais.Text = $"Empréstimos atingidos: {dgvEmprestimo.RowCount}";

                if (dgvEmprestimo.RowCount >= obj.desc_meta)
                {
                    MessageBox.Show("Metas de Empréstimos atingidas com sucesso!", "Parabéns!");

                    btnAlterarMeta.Enabled = false;

                    btnAdicionar.Visible = true;
                }
                else if (DateTime.Today >= cdpFimPrazo.Value)
                {
                    MessageBox.Show("O prazo final de Metas para Empréstimos chegou ao fim", "Parabéns, ver resultados:", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnAlterarMeta.Enabled = false;

                    btnAdicionar.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                obj.desc_meta = int.Parse(txtTitulo.Text);
                obj.dta_inicio = cdpInicioPrazo.Value;
                obj.dta_encerramento = cdpFimPrazo.Value;

                var dao = new MetaDAO();
                dao.AlterarMeta(obj);

                MessageBox.Show("Meta alterada com sucesso !");

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Apenas números são permitidos em Meta Atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Criar nota meta", "Metas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                var frm = new frmAdicionarMeta();
                frm.ShowDialog();

                this.Close();
            }
        }
    }
}
