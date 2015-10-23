using System.Data.Entity;
namespace EntityCodeFirstIndex
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
    }
}
