using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orçamento orçamento)
        {
            orçamento.Valor -= orçamento.Valor*0.02;
        }

        public void Aprova(Orçamento orçamento)
        {
            throw new Exception("Orçamento ja aprovado");
        }

        public void Finaliza(Orçamento orçamento)
        {
           orçamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orçamento orçamento)
        {
            throw new Exception("Orçamento ja Reprovado");
        }
    }
}
