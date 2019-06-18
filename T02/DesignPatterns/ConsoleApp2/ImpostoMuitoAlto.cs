using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto imposto) : base(imposto) { }
        public ImpostoMuitoAlto(): base() { }
        public override double Calcula(Orçamento orçamento)
        {
            return orçamento.Valor * 0.2 + CalculaOutroImposto(orçamento);
           
        }

        
    }
}
