using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orçamento orçamento)
        {
            orçamento.Valor -= orçamento.Valor * 0.05;
        }

        public void Aprova(Orçamento orçamento)
        {
            orçamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orçamento orçamento)
        {
            orçamento.EstadoAtual=new Finalizado();
        }

        public void Reprova(Orçamento orçamento)
        {
            orçamento.EstadoAtual = new Reprovado();

        }
    }
}
