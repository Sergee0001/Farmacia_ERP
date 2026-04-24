using System.ComponentModel.DataAnnotations;

namespace FarmaciaCRUD_V1.Model.Entities
{
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public string Encargado { get; set; }
        public virtual ICollection<DetalleVenta> DetallesVenta { get; set; }

    }
}
