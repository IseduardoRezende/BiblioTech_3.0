using BiblioTech_3._0.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech_3._0.DAO
{
    public class PrateleiraDAO
    {
        #region AdicionarPrateleira
        public void AdicionarPrateleira(Prateleira obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = "insert into tb_prateleira (desc_prateleira) values (@desc_prateleira)";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@desc_prateleira", obj.desc_prateleira);

                    conexao.Open();
                    executaCmd.ExecuteReader();

                    MessageBox.Show("Prateleira inserida com sucesso !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        #endregion

        #region ListarPrateleira
        public DataTable ListarPrateleiraNoComboBox()
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var comboPrateleira = new DataTable();

                    string sql = "select id_prateleira, desc_prateleira as Prateleira from tb_prateleira";

                    var executaCmd = new MySqlCommand(sql, conexao);

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(comboPrateleira);

                    return comboPrateleira;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }
                      
        #endregion
    }
}
