using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDesconto(Orçamento orçamento)
        {
            throw new NotImplementedException();
        }

        public void AplicaDescontoExtra(Orçamento orçamento)
        {
            throw new Exception("Orçamento Finalizado não recebe desconto");
        }

        public void Aprova(Orçamento orçamento)
        {
            throw new Exception("Orçamento ja finalizado");
        }

        public void Finaliza(Orçamento orçamento)
        {
            throw new Exception("Orçamento ja finalizado");
        }

        public void Reprova(Orçamento orçamento)
        {
            throw new Exception("Orçamento ja finalizado");
        }
    }
}
