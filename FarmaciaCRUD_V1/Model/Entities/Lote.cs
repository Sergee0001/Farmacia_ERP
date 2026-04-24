using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaciaCRUD_V1.Model.Entities
{
    public class Lote
    {
        [Key]
        public int IdLote { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Stock { get; set; }
        public virtual Producto Producto { get; set; }
        [ForeignKey("Producto")]
        public int IdProducto { get; set; }

    }
}
