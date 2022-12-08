using BiblioTech_3._0.CustomComponents;
using BiblioTech_3._0.Model;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech_3._0.DAO
{
    public class MetaDAO
    {
        #region AdicionarMeta
        public void AdicionarMeta(Meta obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"insert into tb_meta (dta_inicio, dta_encerramento, desc_meta)
                                   values (@dta_inicio, @dta_encerramento, @desc_meta)";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@dta_inicio", obj.dta_inicio);
                    executaCmd.Parameters.AddWithValue("@dta_encerramento", obj.dta_encerramento);
                    executaCmd.Parameters.AddWithValue("@desc_meta", obj.desc_meta);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Meta inserida com Sucesso !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        #endregion

        #region AlterarMeta
        public void AlterarMeta(Meta obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"update tb_meta set dta_inicio = @dta_inicio, dta_encerramento = @dta_encerramento,
                                                      desc_meta = @desc_meta where id_meta = @id_meta";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue(@"dta_inicio", obj.dta_inicio);
                    executaCmd.Parameters.AddWithValue(@"dta_encerramento", obj.dta_encerramento);
                    executaCmd.Parameters.AddWithValue(@"desc_meta", obj.desc_meta);

                    executaCmd.Parameters.AddWithValue(@"id_meta", obj.id_meta);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        #endregion

        #region RetornaUltimaMeta

        public int RetornaUltimaMeta()
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    int id = 0;

                    string sql = @"select max(id_meta) as id from tb_meta";                    

                    var executaCmd = new MySqlCommand(sql, conexao);
                    
                    conexao.Open();

                    MySqlDataReader dr = executaCmd.ExecuteReader();
                    
                    if (dr.Read())
                    {
                        id = dr.GetInt32("id");
                        return id;
                    }
                    else
                    {                        
                        return 0;
                    }                    
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Erro: " + ex);
                return 0;
            }
        }

        #endregion

        #region RetornaDadosDaMetaPeloID
        public Meta RetornaDadosMetaId(int id)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = "select * from tb_meta where id_meta = @id";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id", id);

                    conexao.Open();

                    MySqlDataReader dr = executaCmd.ExecuteReader();

                    var obj = new Meta();

                    if (dr.Read())
                    {
                        obj.id_meta = dr.GetInt32("id_meta");
                        obj.desc_meta = dr.GetInt32("desc_meta");
                        obj.dta_inicio = dr.GetDateTime("dta_inicio");
                        obj.dta_encerramento = dr.GetDateTime("dta_encerramento");

                        return obj;
                    }
                    else
                    {                       
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region ListarEmprestimoPorPeriodo
        public DataTable ListarEmprestimoPorPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEmprestimo = new DataTable();

                    string sql = @"select
                                   E.id_emprestimo as `Código`,
                                   U.nome as Nome,
                                   U.Email as Email,
                                   U.tel as Contato,
                                   L.titulo as Título,
                                   L.id_isbn as ISBN,
                                   E.dta_retirada as `Data da Retirada`,
                                   E.dta_entrega as `Data de Entrega`
                                   from tb_emprestimo as E 
                                   Inner join tb_livro as L on (E.id_isbn = L.id_isbn)
                                   Inner join tb_usuario as U on (E.id_usuario = U.id_usuario)
                                   where E.dta_retirada between @datainicio and @datafim";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@datainicio", dataInicio);
                    executaCmd.Parameters.AddWithValue("@datafim", dataFim);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaEmprestimo);

                    return tabelaEmprestimo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar comando sql: " + ex);
                return null;
            }
        }

        #endregion       
    }
}