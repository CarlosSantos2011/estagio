using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto )
        {
            this.OutroImposto = outroImposto;
        }
        public Imposto()
        {
            OutroImposto = null;
        }
        protected double CalculaOutroImposto(Orçamento orçamento)
        {
            return (OutroImposto == null ? 0 : OutroImposto.Calcula(orçamento));
        }

        public abstract double Calcula(Orçamento orçamento);
    }
    
}

