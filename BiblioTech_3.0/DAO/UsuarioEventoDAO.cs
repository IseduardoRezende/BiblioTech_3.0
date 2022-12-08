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
    public class UsuarioEventoDAO
    {
        #region AdicionarParticipante

        public void AdicionarParticipante(UsuarioEvento obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = "insert into tb_usuario_evento (id_usuario, id_evento) values (@id_usuario, @id_evento)";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id_usuario", obj.id_usuario);
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

        #region ListarParticipante

        public DataTable ListarParticipante(int id_evento)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    var tabelaAlterarEvento = new DataTable();

                    string sql = @" select tb_usuario.id_usuario as 'Código', 
                                    tb_usuario.nome as 'Nome'
                                    from tb_usuario
                                    inner join tb_usuario_evento
                                    on (tb_usuario.id_usuario = tb_usuario_evento.id_usuario)
                                    inner
                                    join tb_evento
                                    on (tb_usuario_evento.id_evento = tb_evento.id_evento)
                                    where tb_evento.id_evento = @id_evento";

                    var executaCmd = new MySqlCommand(sql, conexao);

                    executaCmd.Parameters.AddWithValue("@id_evento", id_evento);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaAlterarEvento);

                    return tabelaAlterarEvento;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion
      
        #region RemoverParticipante

        public void RemoverParticipante(UsuarioEvento obj)
        {
            try
            {
                using (var conexao = ConnectionFactory.GetConnection())
                {
                    string sql = @"delete from tb_usuario_evento 
                                   where id_usuario = @id_usuario 
                                   and id_evento = @id_evento";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id_usuario", obj.id_usuario);
                    executaCmd.Parameters.AddWithValue("@id_evento", obj.id_evento);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
            }
        }

        #endregion
    }
}