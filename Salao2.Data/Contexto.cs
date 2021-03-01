using Microsoft.EntityFrameworkCore;
using Salao2.Data.Map;
using SalaoT2.Dominio;

namespace Salao2.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-MCO4P9I5\\SQLEXPRESS; Database=Salao2.1; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AgendamentoMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
