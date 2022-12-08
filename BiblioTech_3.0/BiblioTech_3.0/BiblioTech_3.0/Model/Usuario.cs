using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech_3._0.Model
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Email_Opcional { get; set; }
        public string Telefone { get; set; }
        public string Telefone_Opcional { get; set; }
    }
}
