using BiblioTech_3._0.DAO;
using BiblioTech_3._0.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech_3._0
{
    public class Utils
    {
        public void refreshInfoEvento(DataGridView grid, Panel panel)
        {
            var evento = new EventoDAO();
            grid.DataSource = evento.ListarEventos();
            panel.Controls.Clear();
        }       

        public void refreshInfoUsuario(DataGridView grid, Panel panel, bool arquivo)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            if (arquivo)
            {
                grid.DataSource = usuarioDAO.ListarUsuarioArquivado();
            }
            else
            {
                grid.DataSource = usuarioDAO.ListarUsuario();
            }
            panel.Controls.Clear();
        }

        public void refreshInfoAutor(DataGridView grid, Panel panel)
        {
            var autor = new AutorDAO();
            grid.DataSource = autor.ListarAutor();
            panel.Controls.Clear();
        }
        
        public void refreshInfoEditora(DataGridView grid, Panel panel)
        {
            var editora = new EditoraDAO();
            grid.DataSource = editora.ListarEditora();
            panel.Controls.Clear();
        }
        public void refreshInfoEditoraBox(ComboBox box)
        {
            var editora = new EditoraDAO();
            box.DataSource = editora.ListarEditora();
            box.DisplayMember = "Editora";
            box.ValueMember = "Código";
        }

        public void refreshInfoGenero(DataGridView grid, Panel panel)
        {
            var genero = new GeneroDAO();
            grid.DataSource = genero.ListarGenero();            
            panel.Controls.Clear();
        }
        public void refreshInfoGeneroBox(ComboBox box)
        {
            var genero = new GeneroDAO();

            box.DataSource = genero.ListarGenero();
            box.DisplayMember = "Gênero";
            box.ValueMember = "Código";
        }        

        public void refreshInfoPrateleiraBox(ComboBox box)
        {
            var prateleira = new PrateleiraDAO();
            box.DataSource = prateleira.ListarPrateleiraNoComboBox();
            box.DisplayMember = "Prateleira";
            box.ValueMember = "id_prateleira";
        }

        public void refreshInfoEstanteBox(ComboBox box)
        {
            var estante = new EstanteDAO();
            box.DataSource = estante.ListarEstanteNoComboBox();
            box.DisplayMember = "Estante";
            box.ValueMember = "id_estante";
        }
        public void refreshInfoLivro(DataGridView grid, Panel panel)
        {
            var livro = new LivroDAO();
            grid.DataSource = livro.ListarLivro();
            panel.Controls.Clear();
        }
        public void refreshInfoEmprestimo(DataGridView grid, Panel panel)
        {
            var emprestimo = new EmprestimoDAO();
            grid.DataSource = emprestimo.ListarEmprestimo();
            panel.Controls.Clear();
        }       
    }
}