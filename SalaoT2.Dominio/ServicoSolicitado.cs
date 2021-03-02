using System;
using System.Collections.Generic;

namespace SalaoT2.Dominio
{
    public class ServicoSolicitado
    {
        public int Id { get; set; }
        public Servico Servico { get; set; }
        public Funcionario Funcionario { get; set; }
        public StatusServico Status { get; set; }
        public DateTime DtServico { get; set; }
        public decimal ServicoPreco { get; set; }
        public string ServicoSolicitadoServicoPreco { get; set; }
        public string StatusAgenda { get; set; }
        public List<Agendamento> Agenda { get; set; }
        
        
        public enum StatusServico
        {
            ARealizar,
            Realizado,
            Reagendado,
            CanceladoPeloCliente,
            CanceladoPeloSalao
        }

        public void IncluirServicoSolicitado(int id, Servico servico, Funcionario func, decimal servicopreco, string servicoSolicitadoServicoPreco, string statusAgenda)
        {
            Id = id;
            Servico = servico;
            Funcionario = func;
            ServicoPreco = servicopreco;
            ServicoSolicitadoServicoPreco = servicoSolicitadoServicoPreco;
            StatusAgenda = statusAgenda;            
        }
    }
}
