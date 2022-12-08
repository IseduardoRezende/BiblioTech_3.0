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
    public class EditoraDAO
    {
        #region CadastrarEditora

        public void CadastrarEditora(Editora obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = "insert into tb_editora (desc_editora) values (@desc_editora)";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@desc_editora", obj.desc_editora);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Editor ª cadastrado com sucesso !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar editora: " + ex);
            }
        }

        #endregion

        #region ListarEditora

        public DataTable ListarEditora()
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEditora = new DataTable();

                    string sql = "select id_editora as `Código`, desc_editora as Editora from tb_editora";

                    var executaCmd = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaEditora);
                                                      
                    return tabelaEditora;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar editora " + ex);
                return null;
            }
        }

        #endregion
    }
}
