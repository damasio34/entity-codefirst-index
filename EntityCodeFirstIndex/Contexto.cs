using System.Data.Entity;
namespace EntityCodeFirstIndex
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ClienteTypeConfigurantion());
        }
    }
}