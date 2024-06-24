using Microsoft.EntityFrameworkCore;
using multitrabajos_security.Models;

namespace multitrabajos_security.Repositories
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
            
        }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<User> Usuario { get; set; }
    }
}
