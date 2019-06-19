using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public abstract class TemplateDeImpostosCondicional : Imposto
    {
        protected TemplateDeImpostosCondicional()
        {
        }

        protected TemplateDeImpostosCondicional(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        private double Calcula (Orçamento orçamento)
        {
            if(DeveUsarMaximaTaxacao  (orçamento))
            {
                return MaximaTaxacao(orçamento);
            }
            else
            {
                return MinimaTaxacao(orçamento);
            }
        }
        public  abstract bool DeveUsarMaximaTaxacao(Orçamento orçamento);
        public abstract double MaximaTaxacao(Orçamento orçamento);
        public abstract double MinimaTaxacao(Orçamento orçamento);
    }
}
