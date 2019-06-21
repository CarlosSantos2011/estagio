using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EmAprovacao : IEstadoDeUmOrcamento
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
                orçamento.Valor -= orçamento.Valor * 0.05;
                descontoAplicado = true;

            }
            else
            {
                throw new Exception("Desconto já aplicado");
            }
        }

        public void Aprova(Orçamento orçamento)
        {
            orçamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orçamento orçamento)
        {
            throw new Exception("Orcamento em aprovação não podem ir para finalizado diretamente");
        }

        public void Reprova(Orçamento orçamento)
        {
            orçamento.EstadoAtual = new Reprovado();

        }








    }
}





    

