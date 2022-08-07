using Microsoft.EntityFrameworkCore;

namespace ApiGabezk.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            :base(options)
        {
        }
        public DbSet<Cliente> clientes { get; set; }
    }
}
