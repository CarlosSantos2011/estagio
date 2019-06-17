using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class CalculaDesconto
    {
        public class CalculadorDeDesconto
        {
            public double Calcula(Orçamento orçamento)
            {
                Desconto d1 = new DescontoPorCincoItens();
                Desconto d2 = new DescontoPorMaisDeQuinhentosReais();
                Desconto d3 = new SemDesconto();

                d1.Proximo = d2;
                d2.Proximo = d3;

                return d1.Desconta(orçamento);

            }
        }
    }
}
