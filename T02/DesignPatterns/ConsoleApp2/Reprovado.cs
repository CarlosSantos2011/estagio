using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDesconto(Orçamento orçamento)
        {
            throw new NotImplementedException();
        }

        public void AplicaDescontoExtra(Orçamento orçamento)
        {
            throw new Exception("Orçamento reprovado não recebe desconto");
        }

        public void Aprova(Orçamento orçamento)
        {
            throw new Exception("Orçamento já reprovado");
        }

        public void Finaliza(Orçamento orçamento)
        {
           orçamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orçamento orçamento)
        {
            orçamento.EstadoAtual = new Reprovado();
        }
    }
}
