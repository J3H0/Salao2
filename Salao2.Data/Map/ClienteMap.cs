using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoT2.Dominio;

namespace Salao2.Data.Map
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Agendamento");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome);

            builder.Property(c => c.Telefone)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(c => c.CPF)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.HasMany<Agendamento>(c => c.Agendamento)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.IdCliente);
        }
    }
}
