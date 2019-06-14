using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ICCC:Imposto
    {
        public double Calcula(Orçamento orçamento)
        {


            if (orçamento.Valor < 1000)
            {
                return orçamento.Valor * 0.05;
            }
            else if (orçamento.Valor >= 1000 && orçamento.Valor <=3000)
            {
                return orçamento.Valor * 0.07;
            }
            else 
            {
                return orçamento.Valor * 0.08 + 30.00;
            }

                   
        }
       
    }
}
