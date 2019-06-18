using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ICMS:Imposto
    {
        public ICMS(Imposto imposto): base(imposto){ }
       
        public ICMS() : base() { }

        public override double Calcula(Orçamento orçamento)
        {
            return orçamento.Valor * 0.05 + CalculaOutroImposto(orçamento);

        }
    }
}
