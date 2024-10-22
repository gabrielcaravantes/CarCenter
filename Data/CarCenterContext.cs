using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CarCenter.Data
{
    public class CarCenterContext : DbContext
    {
        public CarCenterContext(DbContextOptions<CarCenterContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Nota> Notas { get; set; }
    }
}
