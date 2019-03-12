using Soyuz.Domain.Entities;
using Soyuz.Infra.Repository.Mappings;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Soyuz.Infra.Repository.Context
{
    public class DataContext : DbContext
    {
        public DataContext():base(ConfigurationManager.ConnectionStrings["Soyuz"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new PlanoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
        }

        public DbSet<Plano> Planos { get; set; }
        public DbSet<Cliente> Clientes  { get; set; }
    }
}
