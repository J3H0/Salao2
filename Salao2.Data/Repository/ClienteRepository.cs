using System.Collections.Generic;
using System.Linq;
using SalaoT2.Dominio;


namespace Salao2.Data.Repository
{
    class ClienteRepository
    {
        private readonly Contexto contexto;
        public ClienteRepository()
        {
            contexto = new Contexto();
        }

        public void Incluir(Cliente cliente)
        {
            contexto.Cliente.Add(cliente);
            contexto.SaveChanges();
        }

        public Cliente Selecionar(int id)
        {
            return contexto.Cliente.FirstOrDefault(x => x.Id == id);
        }

        public List<Cliente> SelecionarTudo()
        {
            return contexto.Cliente.ToList();
            //Esta List esta vazia------terminar de ver a aula do dia 24/fev
        }

        public void Alterar(Cliente cliente)
        {
            contexto.Cliente.Update(cliente);
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            var cliente = Selecionar(id);
            contexto.Cliente.Remove(cliente);
            contexto.SaveChanges();
        }
    }
}
