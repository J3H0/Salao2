using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SalaoT2.Dominio;


namespace Salao2.Data.Map
{
    public class AgendamentoMap : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("Agendamento");

            builder.HasKey(x => x.Id);
   
            builder.Property(x => x.ServicoSolicitado)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(x => x.DtAgendamento)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(x => x.DataChegada)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(x => x.Anotacao)
               .HasColumnType("varchar(100)");


                builder.Property(x => x.ServicoPreco)
                .HasColumnType("varchar(100)")
                .IsRequired();

            
        }
    }
}
