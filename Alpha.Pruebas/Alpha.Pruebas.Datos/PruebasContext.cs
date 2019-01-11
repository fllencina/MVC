using Alpha.Pruebas.Modelo.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Alpha.Pruebas.Datos
{
    public class PruebasContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        public DbSet<Contacto> Contactos { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();



        }

    }
}