using System.ComponentModel.DataAnnotations;

namespace FarmaciaCRUD_V1.Model.Entities
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        //antes era como un null no habia caja ahora es como una caja vacia 
        public virtual ICollection<Lote> Lotes { get; set; } = new List<Lote>();


    }
}
