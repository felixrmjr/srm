using SRM.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SRM.Repository.Maps
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap() : this("dbo") { }

        public ClienteMap(string schema)
        {
            ToTable(schema + ".Cliente");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Nome).HasColumnName("Nome").IsRequired().HasColumnType("varchar").HasMaxLength(128);
            Property(x => x.Email).HasColumnName("Email").IsRequired().HasColumnType("varchar").HasMaxLength(128);
            Property(x => x.Telefone).HasColumnName("Telefone").IsRequired().HasColumnType("varchar").HasMaxLength(128);
            Property(x => x.LimiteCompra).HasColumnName("LimiteCompra").IsRequired().HasColumnType("decimal").HasPrecision(20, 2);
            Property(x => x.DataCadastro).HasColumnName("DataCadastro").IsRequired().HasColumnType("datetime");
        }
    }
}
