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
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"insert into tb_evento (tema, desc_evento, dta_evento, status_evento)
                                    values (@tema, @desc_evento, @dta_evento, @status_evento)";

                    MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@tema", obj.Tema);
                    executaCmd.Parameters.AddWithValue("@desc_evento", obj.desc_evento);
                    executaCmd.Parameters.AddWithValue("@dta_evento", obj.data_evento);
                    executaCmd.Parameters.AddWithValue("@status_evento", obj.Status);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();
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
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEventos = new DataTable();

                    string sql = "select * from vEventos";

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
        
        #region AlterarEvento
        public void AlterarEvento(Evento obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"update tb_evento set tema=@tema, desc_evento=@desc_evento,
                                        dta_evento=@dta_evento where id_evento=@id_evento";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@tema", obj.Tema);
                    executaCmd.Parameters.AddWithValue("@desc_evento", obj.desc_evento);
                    executaCmd.Parameters.AddWithValue("@dta_evento", obj.data_evento);
                    executaCmd.Parameters.AddWithValue("@id_evento", obj.id_evento);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);        
            }
        }
                
        #endregion

        #region PesquisarEvento
        public DataTable PesquisarEvento(string tema)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEvento = new DataTable();

                    string sql = "select * from vEventos where Tema=@Tema";

                    MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@Tema", tema);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaEvento);

                    return tabelaEvento;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region BuscarEventoPorNome
        public DataTable BuscarEventoPorNome(string tema)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEvento = new DataTable();

                    string sql = "select * from vEventos where Tema like @Tema";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@Tema", tema);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaEvento);

                    return tabelaEvento;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region ListarEventosArquivados
        public DataTable ListarEventosArquivados()
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEventos = new DataTable();

                    string sql = "select * from vEventosArquivados";

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
        
        #region AlterarEventoArquivado
        public void AlterarEventoArquivado(int idEvento, bool status)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = "update tb_evento set status_evento=@status_evento where id_evento=@idEvento";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@status_evento", status);
                    executaCmd.Parameters.AddWithValue("@idEvento", idEvento);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        #endregion

        #region RetornaID

        public int retornaIdUltimoEvento()
        {
            try
            {
                int id = 0;
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = "select max(id_evento) as id from tb_evento";

                    var executaCmd = new MySqlCommand(sql, conexao);

                    conexao.Open();

                    MySqlDataReader reader = executaCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        id = reader.GetInt32("id");
                    }
                    
                    return id;                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
                return 0;
            }
        }

        #endregion

        #region BuscarEventoArquivadoPorNome
        public DataTable BuscarEventoArquivadoPorNome(string tema)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEvento = new DataTable();

                    string sql = "select * from vEventosArquivados where Tema like @Tema";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@Tema", tema);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaEvento);

                    return tabelaEvento;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region PesquisarEventoArquivado

        public DataTable PesquisarEventoArquivado(string tema)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEvento = new DataTable();

                    string sql = "select * from vEventosArquivados where Tema=@Tema";

                    MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@Tema", tema);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaEvento);

                    return tabelaEvento;
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

