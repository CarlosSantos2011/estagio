using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;
        public void AplicaDesconto(Orçamento orçamento)
        {
            throw new NotImplementedException();
        }

        public void AplicaDescontoExtra(Orçamento orçamento)
        {
            if (!descontoAplicado)
            {
                orçamento.Valor -= orçamento.Valor * 0.02;
            }
            else
            {
                throw new Exception("Desconto já aplicado");
            }
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
