using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech_3._0.Model
{
    public class Evento
    {
        public int id_evento { get; set; }
        public DateTime data_evento { get; set; }
        public string Tema { get; set; }
        public string desc_evento { get; set; }        
    }
}
