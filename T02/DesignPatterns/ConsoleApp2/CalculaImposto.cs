using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class CalculaImposto

    {
        public void RealizaCalculo(Orçamento orçamento, Imposto imposto)
        {
            double valor = imposto.Calcula(orçamento);
            Console.WriteLine(valor);
        }

      
        

    }
}
