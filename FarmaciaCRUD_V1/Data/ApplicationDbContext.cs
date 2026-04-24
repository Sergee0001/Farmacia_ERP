using FarmaciaCRUD_V1.Model.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FarmaciaCRUD_V1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //representan las tablas de la base de datos que el contexto puede manipular
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<Lote> Lote { get; set; }
        public DbSet<DetalleVenta> DetalleVenta { get; set; }
        //establece exactamente a la base de datos que me quiero conectar sino lo he hechi 
        //por ejemplo en Programs.cs(esta parte sirve para ejecutar por consola la migracion)

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=CASTRO;" +
                "Database=FarmaciaCRUD_V1;" +
                "User id=sa;" +
                "Password=948784915;" +
                "MultipleActiveResultSets=true;" +
                "Encrypt=False;"
                );
        }
    }
}
