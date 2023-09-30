using ControlLawyersApi.Entities;
using Microsoft.EntityFrameworkCore;



namespace ControlLawyersApi.Context
{
  

        public class ApplicationDbContext : DbContext
        {
            public DbSet<Usuario> usuarios { get; set; }

            public DbSet<Categoria> categorias { get; set; }
            public DbSet<Cliente> clientes { get; set; }

            public DbSet<Asesoria> asesorias { get; set; }

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }
        }
    }



