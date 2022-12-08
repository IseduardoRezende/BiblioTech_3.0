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
    public class EventoDAO
    {
        #region CadastrarEvento
        public void CadastrarEvento(Evento obj)
        {
            try
            {
                using(var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"insert into tb_evento (tema, desc_evento, dta_evento)
                                    values (@tema, @desc_evento, @dta_evento)";

                    MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@tema", obj.Tema);
                    executaCmd.Parameters.AddWithValue("@desc_evento", obj.desc_evento);
                    executaCmd.Parameters.AddWithValue("@dta_evento", obj.data_evento);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Evento cadastrado com sucesso !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar evento: " + ex);
            }
        }

        #endregion

        #region ListarEventos
        public DataTable ListarEventos()
        {
            try
            {
                using(var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEventos = new DataTable();

                    string sql = "select * from tb_evento";

                    MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaEventos);

                    return tabelaEventos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }               
        
        #endregion

        //A fazer: Buscar por tema, Pesquisar;
    }
}