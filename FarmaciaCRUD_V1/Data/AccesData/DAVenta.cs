using FarmaciaCRUD_V1.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace FarmaciaCRUD_V1.Data.AccesData
{
    public class DAVenta
    {
        public IEnumerable<DetalleVenta> GetVenta()
        {
            var Listado = new List<DetalleVenta>();
            using (var db = new ApplicationDbContext())
            {
                Listado = db.DetalleVenta.ToList();
                /*Listado = db.DetalleVenta
                .Include(d => d.Lote)
                .Include(d => d.Venta)
                .ToList();*/
            }
            return Listado;

        }
    }
}
