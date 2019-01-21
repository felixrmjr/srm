using SRM.Domain.Entities;

namespace SRM.Repository.Maps
{
    public class ClienteMap
    {

        
        //protected override void ConfigurarMapeamento(EntityTypeBuilder<Cliente> builder)
        //{
        //    builder.ToTable("Cliente", "dbo");

        //    builder.Property(x => x.Id).HasColumnName($"{nameof(Cliente)}Id").IsRequired().ValueGeneratedOnAdd();

        //    builder.HasIndex(x => x.CpfCnpj).IsUnique();
        //    builder.Property(x => x.CpfCnpj).HasColumnType("varchar(20)");
        //    builder.Property(x => x.RazaoSocial).HasMaxLength(512).IsRequired();
        //    builder.Property(x => x.Tipo).IsRequired();
        //    builder.Property(x => x.status).HasColumnName("StatusId").IsRequired();
        //    builder.Property(x => x.RevendedorId).IsRequired();
        //    builder.Property(x => x.PlanoId);
        //    builder.Property(x => x.MotivoBloqueio);
        //    builder.Property(x => x.FaturaCicloId);

        //    builder.Ignore(x => x.Ativo);
        //}
    }
}
