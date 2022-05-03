using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClickExpress.Models;

namespace ClickExpress.Models
{
    public class ApplicationDbContext : DbContext // classe criada
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Prestador> Prestadores { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

    }
}
