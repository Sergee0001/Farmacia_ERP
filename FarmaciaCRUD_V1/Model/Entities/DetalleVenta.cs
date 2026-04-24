using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaciaCRUD_V1.Model.Entities
{
    public class DetalleVenta
    {
        [Key]
        public int IdDetalleVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
         // FK correcta
        [ForeignKey("Venta")]
        public int IdVenta { get; set; }
        public virtual Venta Venta { get; set; }
        // FK correcta
        [ForeignKey("Lote")]
        public int IdLote { get; set; }
        public virtual Lote Lote { get; set; }

    }
}
