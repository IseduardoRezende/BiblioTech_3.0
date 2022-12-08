using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech_3._0.Model
{
    public class Livro
    {
        public string id_isbn { get; set; }
        public int id_genero { get; set; }
        public int id_estante { get; set; }
        public int id_editora { get; set; }
        public int id_prateleira { get; set; }
        public int id_autor { get; set; }
        public string Titulo { get; set; }
        public string CDD { get; set; }
        public string Exemplar { get; set; }
        public string Volume { get; set; }
        public bool Status { get; set; }
        public bool Status_Emprestimo { get; set; }
    }
}