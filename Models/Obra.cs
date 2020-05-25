using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConstruirApp.Models
{
    public class Obra
    {
        public int ObraId { get; set; }
        public string Nome { get; set; }
        
        private List<EtapaObra> _etapas = new List<EtapaObra>();
        public List<EtapaObra> EtapaObras { get { return _etapas; } set { _etapas = value; } }
        

    }
}
