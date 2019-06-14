using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ICMS:Imposto
    {
        public double Calcula(Orçamento orçamento)
        {
            return orçamento.Valor * 0.05;

        }
    }
}
