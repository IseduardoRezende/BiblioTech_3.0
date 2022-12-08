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
    public class EmprestimoDAO
    {
        #region AdicionarEmprestimo
        public void AdicionarEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"insert into tb_emprestimo (id_usuario, id_isbn, dta_retirada, dta_entrega, status_emprestimo) values 
                                    (@id_usuario, @id_isbn, @dta_retirada, @dta_entrega, @status_emprestimo)";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id_usuario", emprestimo.id_usuario);
                    executaCmd.Parameters.AddWithValue("@id_isbn", emprestimo.id_isbn);
                    executaCmd.Parameters.AddWithValue("@dta_retirada", emprestimo.dta_retirada);
                    executaCmd.Parameters.AddWithValue("@dta_entrega", emprestimo.dta_entrega);
                    executaCmd.Parameters.AddWithValue("@status_emprestimo", emprestimo.status_emprestimo);
                                                                                                            
                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Livro emprestado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        #endregion
        
        #region ListarEmprestimo

        public DataTable ListarEmprestimo()
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEmprestimo = new DataTable();

                    string sql = "select * from vemprestimo";

                    var executaCmd = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaEmprestimo);

                    return tabelaEmprestimo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region AlterarEmprestimo
        public void AlterarEmprestimo(Emprestimo obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"update tb_emprestimo set id_usuario = @id_usuario,
                                                            dta_entrega = @dta_entrega where id_emprestimo = @id_emprestimo";
                                                                                                
                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id_usuario", obj.id_usuario);
                    executaCmd.Parameters.AddWithValue("@dta_entrega", obj.dta_entrega);

                    executaCmd.Parameters.AddWithValue("@id_emprestimo", obj.id_emprestimo);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Empréstimo alterado com sucesso !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        #endregion

        #region EmprestimoAtivo

        public void EmprestimoAtivo(int id_emprestimo, bool status_emprestimo, DateTime dta_entrega)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"update tb_emprestimo set status_emprestimo = @status_emprestimo, 
                                                            dta_entrega = @dta_entrega
                                                            where id_emprestimo = @id_emprestimo";  

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@status_emprestimo", status_emprestimo);
                    executaCmd.Parameters.AddWithValue("@dta_entrega", dta_entrega);
                    executaCmd.Parameters.AddWithValue("@id_emprestimo", id_emprestimo);

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

        #region ListarEmprestimoArquivado
        public DataTable ListarEmprestimoArquivado()
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEmprestimo = new DataTable();

                    string sql = "select * from vEmprestimoarquivado";

                    var executaCmd = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaEmprestimo);

                    return tabelaEmprestimo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region BuscarEmprestimoPorNome
        public DataTable BuscarEmprestimoPorNome(string id_isbn)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEmprestimo = new DataTable();

                    string sql = "select * from vEmprestimoarquivado where Título like @id_isbn";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id_isbn", id_isbn);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaEmprestimo);

                    return tabelaEmprestimo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region PesquisarEmprestimo
        public DataTable PesquisarEmprestimo(string id_isbn)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEmprestimo = new DataTable();

                    string sql = "select * from vEmprestimoarquivado where Título = @id_isbn";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id_isbn", id_isbn);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaEmprestimo);

                    return tabelaEmprestimo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region ListarUsuarioEmprestimo

        public DataTable ListarUsuarioEmprestimo(int id_emprestimo)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaUsuario = new DataTable();

                    string sql = @"select U.id_usuario as 'Código', 
                                   U.nome as 'Nome'
                                   from tb_emprestimo as E
                                   inner join tb_usuario as U on (U.id_usuario = E.id_usuario)
                                   where id_emprestimo = @id_emprestimo";
                                  

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id_emprestimo", id_emprestimo);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaUsuario);

                    return tabelaUsuario;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region

        #region BuscarEmprestimo
        public DataTable BuscarEmprestimo(int id)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaEmprestimo = new DataTable();

                    string sql = "select * from vEmprestimo where Código = @id_emprestimo";
                    var executaCmd = new MySqlCommand(sql, conexao);

                    executaCmd.Parameters.AddWithValue("@id_emprestimo", id);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaEmprestimo);

                    return tabelaEmprestimo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion


        #endregion

    }
}