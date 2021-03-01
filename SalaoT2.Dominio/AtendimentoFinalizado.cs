using System;
using System.Collections.Generic;


namespace SalaoT2.Dominio
{
    public class AtendimentoFinalizado 
    {
        public List<ServicoSolicitado> ServicoSolicitado { get; set; }

        public bool AgendarServicos(int id, Cliente cliente, List<ServicoSolicitado> servicosSolicitados,
            DateTime dtAgendamento, string anotacao = "")
        { 
            //agenda.IncluirAgendamento(id, cliente, servicosSolicitados, dtAgendamento, anotacao);
            return true;
        }


        internal void IncluirAtendimentoFinalizado(int id, ServicoSolicitado servicoParaAgendar, DateTime dtAgendamento, List<Agendamento> agenda, 
            string servicoSolicitadoServicoPreco, string statusAgenda)
        {
            throw new NotImplementedException();
        }

       // public class MinhaBaseAgendamento
       // {
          //  public List<Agendamento> Agendamento { get; set; }

           // public bool AgendarServicos(int id, Cliente cliente, List<ServicoSolicitado> servicosSolicitados,
              //  DateTime dtAgendamento, string anotacao = "")
          //  {
               // Agendamento agenda = new Agendamento();
                //agenda.IncluirAgendamento(id, cliente, servicosSolicitados, dtAgendamento, anotacao);
             //   return true;
           // }
       // }
    }
}
