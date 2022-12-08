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
    public class GeneroDAO
    {
        #region AdicionarGenero

        public void AdicionarGenero(Genero obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = "insert into tb_genero (desc_genero) values (@desc_genero)";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@desc_genero", obj.Nome_Genero);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Gênero cadastrado com sucesso !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        #endregion

        #region ListarGenero

        public DataTable ListarGenero()
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaGenero = new DataTable();

                    string sql = "select id_genero as `Código`, desc_genero as `Gênero` from tb_genero";

                    var executaCmd = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaGenero);
                    
                    return tabelaGenero;    
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
