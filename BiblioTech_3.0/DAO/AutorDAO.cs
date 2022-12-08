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
    public class AutorDAO
    {
        #region AdicionarAutor 
        public void AdicionarAutor(Autor obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = "insert into tb_autor (desc_autor) values (@desc_autor)";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@desc_autor", obj.Nome_Autor);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Autor cadastrado com sucesso !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar autor " + ex);
            }
        }

        #endregion

        #region ListarAutor

        public DataTable ListarAutor()
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaAutor = new DataTable();

                    string sql = "select id_autor as Código, desc_autor as `Nome` from tb_autor";

                    var executaCmd = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaAutor);

                    return tabelaAutor;                
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
                return null;
            }
        }
                
        #endregion
    }
}
