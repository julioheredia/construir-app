using System.ComponentModel.DataAnnotations.Schema;

namespace ConstruirApp.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Descricao { get; set; }
        public string Modelo { get; set; }
        public string LocalCompra { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        [ForeignKey("EtapaObraId")]
        public EtapaObra EtapaObra { get; set; }
    }
}
