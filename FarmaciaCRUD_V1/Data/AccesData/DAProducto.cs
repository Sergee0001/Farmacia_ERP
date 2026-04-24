using FarmaciaCRUD_V1.Model.Entities;
namespace FarmaciaCRUD_V1.Data.AccesData
{
    public class DAProducto
    {
        private readonly ApplicationDbContext _context;

        public DAProducto(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET ALL
        public IEnumerable<Producto> GetProducto()
        {
            return _context.Producto.ToList();
        }

        // GET BY ID
        //busca un registro por su id(clave primaria), si no lo encuentra devuelve null
        //se puede usar el metodo Find() porque _context es una instancia de ApplicationDbContext que hereda de DbContext
        public Producto GetById(int id)
        {
            return _context.Producto.Find(id);
        }

        // CREATE
        public Producto Add(Producto producto)
        {
            _context.Producto.Add(producto);
            _context.SaveChanges();
            return producto;
        }

        // UPDATE
        public Producto Update(int id, Producto producto)
        {
            var existing = _context.Producto.Find(id);
            if (existing == null) return null;

            existing.Nombre = producto.Nombre;
            existing.Precio = producto.Precio;

            _context.SaveChanges();
            return existing;
        }

        // DELETE
        public bool Delete(int id)
        {
            var producto = _context.Producto.Find(id);
            if (producto == null) return false;

            _context.Producto.Remove(producto);
            _context.SaveChanges();
            return true;
        }
    }
}
