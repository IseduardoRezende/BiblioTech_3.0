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
    public class EstanteDAO
    {
        #region AdicionarEstante

        public void AdicionarEstante(Estante obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = "insert into tb_estante (desc_estante) values (@desc_estante)";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@desc_estante", obj.desc_estante);

                    conexao.Open();
                    executaCmd.ExecuteReader();

                    MessageBox.Show("Estante inserida com sucesso !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        #endregion

        #region ListarEstante
        
        public DataTable ListarEstanteNoComboBox()
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var comboEstante = new DataTable();

                    string sql = "select id_estante, desc_estante as Estante from tb_estante";

                    var executaCmd = new MySqlCommand(sql, conexao);

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(comboEstante);

                    return comboEstante;
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
