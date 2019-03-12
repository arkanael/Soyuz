using Soyuz.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Soyuz.Infra.Repository.Mappings
{

    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasColumnName("Id")
                .IsRequired();

            Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(60)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.Email)
                .HasColumnName("Email")
                .HasMaxLength(70)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("date")
                .IsRequired();

            Property(c => c.IdPlano)
                .HasColumnName("IdPlano")
                .IsRequired();
            
            HasRequired(c => c.Plano)
                .WithMany(p => p.Clientes)
                .HasForeignKey(c => c.IdPlano);
        }
    }
}
