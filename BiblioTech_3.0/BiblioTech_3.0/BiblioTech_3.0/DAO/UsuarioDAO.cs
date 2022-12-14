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
    public class UsuarioDAO
    {
        #region CadastrarUsuario
        public void CadastrarUsuario(Usuario obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"insert into tb_usuario (nome, email, email_opcional, tel, tel_opcional) 
                                values (@nome, @email, @email_opcional, @tel, @tel_opcional)";

                    MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@nome", obj.Nome);
                    executaCmd.Parameters.AddWithValue("@email", obj.Email);
                    executaCmd.Parameters.AddWithValue("@email_opcional", obj.Email_Opcional);
                    executaCmd.Parameters.AddWithValue("@tel", obj.Telefone_Opcional);
                    executaCmd.Parameters.AddWithValue("@tel_opcional", obj.Telefone_Opcional);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastrado com Sucesso !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no Cadastro " + ex);
            }
        }

        #endregion

        #region AlterarUsuario
        public void AlterarUsuario(Usuario obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"update tb_usuario set nome=@nome, email=@email, email_opcional=@email_opcional, tel=@tel, tel_opcional=@tel_opcional 
                                where id_usuario=@id_usuario";

                    MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@nome", obj.Nome);
                    executaCmd.Parameters.AddWithValue("@email", obj.Email);
                    executaCmd.Parameters.AddWithValue("@email_opcional", obj.Email_Opcional);
                    executaCmd.Parameters.AddWithValue("@tel", obj.Telefone);
                    executaCmd.Parameters.AddWithValue("@tel_opcional", obj.Telefone_Opcional);
                    executaCmd.Parameters.AddWithValue("@id_usuario", obj.id_usuario);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Usuário alterado com sucesso");                   
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
            }            
        }
        
        #endregion

        #region ListarUsuario

        public DataTable ListarUsuario()
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {

                    DataTable tabelaCliente = new DataTable();

                    string sql = "select * from vtb_usuario";

                    MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                    conexao.Open();

                    executaCmd.ExecuteNonQuery();

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(executaCmd);
                    sqlData.Fill(tabelaCliente);

                    conexao.Close();

                    return tabelaCliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clientes não encontrados " + ex);
                return null;
            }
        }

        #endregion
       
        #region PesquisarUsuario
        public DataTable PesquisarUsuario(string nome)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {

                    DataTable tabelaCliente = new DataTable();

                    string sql = "select * from tb_usuario where nome = @nome";

                    MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@nome", nome);

                    conexao.Open();

                    executaCmd.ExecuteNonQuery();

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(executaCmd);
                    sqlData.Fill(tabelaCliente);

                    conexao.Close();

                    return tabelaCliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clientes não encontrados " + ex);
                return null;
            }
        }


        #endregion

        #region BuscarPorNome
        public DataTable BuscarUsuarioPorNome(string nome)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {

                    DataTable tabelaCliente = new DataTable();

                    string sql = "select * from tb_usuario where nome = @nome";

                    MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@nome", nome);

                    conexao.Open();

                    executaCmd.ExecuteNonQuery();

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(executaCmd);
                    sqlData.Fill(tabelaCliente);

                    conexao.Close();

                    return tabelaCliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clientes não encontrados " + ex);
                return null;
            }
        }

        #endregion

        #region ArquivarUsuario

        //Para Desenvolver

        #endregion

    }
}
