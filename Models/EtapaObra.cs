using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConstruirApp.Models
{
    public class EtapaObra
    {
        public int EtapaObraId { get; set; }
        public string Etapa { get; set; }
        
        [ForeignKey("ObraId")]
        public Obra Obra { get; set; }
        public List<Item> Itens { get; set; }
    }
}
