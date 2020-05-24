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
        public List<EtapaObra> EtapaObras {
            get => new List<EtapaObra>();
            set => EtapaObras = EtapaObras; 
        }
    }
}
