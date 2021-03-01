using System.Collections.Generic;
using SalaoT2.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Salao2.Data.Repository
{
    public class AgendamentoRepository
    {
        private readonly Contexto contexto;
        public AgendamentoRepository()
        {
            contexto = new Contexto();
        }

        public void Incluir(Agendamento agendamento)
        {
            contexto.Agendamento.Add(agendamento);
            contexto.SaveChanges();
        }

        public Agendamento Selecionar(int id)
        {
            return contexto.Agendamento.FirstOrDefault(x => x.Id == id);
        }

        public List<Agendamento> SelecionarTudo()
        {
            return contexto.Agendamento.ToList();
        }

        public void Alterar(Agendamento agendamento)
        {
            contexto.Agendamento.Update(agendamento);
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            var agendamento = Selecionar(id);
            contexto.Agendamento.Remove(agendamento);
            contexto.SaveChanges();
        }
    }
}
