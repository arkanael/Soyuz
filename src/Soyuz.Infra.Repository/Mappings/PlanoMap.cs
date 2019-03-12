using Soyuz.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Soyuz.Infra.Repository.Mappings
{

    public class PlanoMap : EntityTypeConfiguration<Plano>
    {
        public PlanoMap()
        {
            ToTable("Plano");

            HasKey(p => p.Id);

            Property(p => p.Id)
               .HasColumnName("Id")
               .IsRequired();

            Property(p => p.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
