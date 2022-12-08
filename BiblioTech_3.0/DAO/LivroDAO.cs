using BiblioTech_3._0.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech_3._0.DAO
{
    public class LivroDAO
    {
        #region CadastrarLivro

        public void CadastrarLivro(Livro obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"insert into tb_livro (id_isbn, id_genero, id_estante, id_editora, id_prateleira,
                                                         id_autor, titulo, CDD, exemplar, volume, status_livro, status_livro_emprestimo) 
                                                         values (@id_isbn, @id_genero, @id_estante, @id_editora, @id_prateleira,
                                                         @id_autor, @titulo,@CDD, @exemplar, @volume, @status_livro, @status_livro_emprestimo)";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id_isbn", obj.id_isbn);
                    executaCmd.Parameters.AddWithValue("@id_genero", obj.id_genero);
                    executaCmd.Parameters.AddWithValue("@id_estante", obj.id_estante);
                    executaCmd.Parameters.AddWithValue("@id_editora", obj.id_editora);
                    executaCmd.Parameters.AddWithValue("@id_prateleira", obj.id_prateleira);
                    executaCmd.Parameters.AddWithValue("@id_autor", obj.id_autor);
                    executaCmd.Parameters.AddWithValue("@titulo", obj.Titulo);
                    executaCmd.Parameters.AddWithValue("@CDD", obj.CDD);
                    executaCmd.Parameters.AddWithValue("@exemplar", obj.Exemplar);
                    executaCmd.Parameters.AddWithValue("@volume", obj.Volume);
                    executaCmd.Parameters.AddWithValue("@status_livro", obj.Status);
                    executaCmd.Parameters.AddWithValue("@status_livro_Emprestimo", obj.Status_Emprestimo);
                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Livro cadastrado com sucesso !");                
                }                
            }
            catch (Exception)
            {
                MessageBox.Show($"Erro ao cadastrar Livro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region ListarLivro

        public DataTable ListarLivro()
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaLivro = new DataTable();

                    string sql = "select * from vLivros";

                    var executaCmd = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaLivro);

                    return tabelaLivro;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region ALterarLivro
        
        public void AlterarLivro(Livro obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"update tb_livro set id_isbn=@id_isbn, id_genero=@id_genero, id_estante=@id_estante, id_editora=@id_editora, 
                                                       id_prateleira=@id_prateleira, id_autor=@id_autor, titulo=@titulo, CDD=@CDD, exemplar=@exemplar,
                                                       volume=@volume where id_isbn = @id_isbn";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id_isbn", obj.id_isbn);
                    executaCmd.Parameters.AddWithValue("@id_genero", obj.id_genero);
                    executaCmd.Parameters.AddWithValue("@id_estante", obj.id_estante);
                    executaCmd.Parameters.AddWithValue("@id_editora", obj.id_editora);
                    executaCmd.Parameters.AddWithValue("@id_prateleira", obj.id_prateleira);
                    executaCmd.Parameters.AddWithValue("@id_autor", obj.id_autor);
                    executaCmd.Parameters.AddWithValue("@titulo", obj.Titulo);
                    executaCmd.Parameters.AddWithValue("@CDD", obj.CDD);
                    executaCmd.Parameters.AddWithValue("@exemplar", obj.Exemplar);
                    executaCmd.Parameters.AddWithValue("@volume", obj.Volume);                   
                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Livro alterado com Sucesso !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        #endregion

        #region LivroArquivado

        public void LivroArquivado(string id_isbn, bool status_livro, bool status_livro_emprestimo)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"update tb_livro set status_livro=@status_livro, status_livro_emprestimo=@status_livro_emprestimo 
                                          where id_isbn = @id_isbn";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@status_livro", status_livro);
                    executaCmd.Parameters.AddWithValue("@status_livro_emprestimo", status_livro_emprestimo);
                    executaCmd.Parameters.AddWithValue("@id_isbn", id_isbn);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na arquivação: " + ex);
            }
        }

        #endregion

        #region LivroEmprestado
        public void LivroEmprestado(string id_isbn, bool status_livro_emprestimo)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"update tb_livro set status_livro_emprestimo = @status_livro_emprestimo 
                                                       where id_isbn = @id_isbn";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@status_livro_emprestimo", status_livro_emprestimo);
                    executaCmd.Parameters.AddWithValue("@id_isbn", id_isbn);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar status do livro: " + ex);   
            }
        }

        #endregion

        #region ListarLivroArquivado

        public DataTable ListarLivroArquivado()
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaLivrosArquivados = new DataTable();

                    string sql = "select * from vLivrosArquivados";

                    var executaCmd = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaLivrosArquivados);

                    return tabelaLivrosArquivados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region BuscarLivroPorTitulo

        public DataTable BuscarLivroPorTitulo(string titulo)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaLivro = new DataTable();

                    string sql = "select * from vLivros where Título like @Título";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@Título", titulo);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaLivro);

                    return tabelaLivro;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region PesquisarPorLivro

        public DataTable PesquisarPorLivro(string titulo)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaLivro = new DataTable();

                    string sql = "select * from vLivros where Título = @Título";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@Título", titulo);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaLivro);

                    return tabelaLivro;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region BuscarLivroPorTituloArquivado

        public DataTable BuscarLivroPorTituloArquivado(string titulo)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaLivro = new DataTable();

                    string sql = "select * from vLivrosArquivados where Título like @Título";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@Título", titulo);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaLivro);

                    return tabelaLivro;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region PesquisarPorLivroArquivado

        public DataTable PesquisarPorLivroArquivado(string titulo)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaLivro = new DataTable();

                    string sql = "select * from vLivrosArquivados where Título = @Título";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@Título", titulo);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaLivro);

                    return tabelaLivro;
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
