using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech_3._0.Model
{
    public class Emprestimo
    {
        public int id_emprestimo { get; set; }
        public int id_usuario { get; set; }
        public string id_isbn { get; set; }                    
        
        public DateTime dta_retirada { get; set; }

        public bool status_emprestimo { get; set; }

        public DateTime dta_entrega { get; set; }
    }
}
