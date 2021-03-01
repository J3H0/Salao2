using System;
using System.Collections.Generic;


namespace SalaoT2.Dominio
{
    public class MinhaBaseAgendamento 
    {
        public List<Agendamento> Agendamento { get; set; }

        public bool AgendarServicos()
        {
            Agendamento agenda = new Agendamento();
            //agenda.IncluirAgendamento(id, cliente, servicosSolicitados, dtAgendamento, anotacao);
            return true;
        }
    }
}
