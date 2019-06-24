using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ISS : Imposto

    {
        public ISS(Imposto outroImposto) : base(outroImposto) { }

        public ISS(): base() { }

        public override double Calcula(Orçamento orçamento)
        {
            return orçamento.Valor * 0.06  + CalculaOutroImposto(orçamento);
        }

    }
}
