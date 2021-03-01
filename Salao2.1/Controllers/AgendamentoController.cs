using Microsoft.AspNetCore.Mvc;
using Salao2.Data.Repository;
using SalaoT2.Dominio;
using System.Collections.Generic;

namespace Salao2._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        private readonly AgendamentoRepository repo;

        public AgendamentoController()
        {
            repo = new AgendamentoRepository();
        }

        [HttpGet]
        public IEnumerable<Agendamento> Get()
        {
            return repo.SelecionarTudo(); 
        }

        [HttpGet("{id}")]
        public Agendamento Get(int id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Agendamento> Post([FromBody] Agendamento agendamento)
        {
            repo.Incluir(agendamento);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Agendamento> Put(int id, [FromBody] Agendamento agendamento)
        {
            repo.Alterar(agendamento);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Agendamento> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
