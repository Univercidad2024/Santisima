using Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Santisima.Components
{
    

    namespace Santisima.Server.Data
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Empleado> Empleados { get; set; }
            public DbSet<Servicio> Servicios { get; set; }
            public DbSet<Cita> Citas { get; set; }
            public DbSet<HistorialServicio> HistorialServicios { get; set; }
        }
    }

}
