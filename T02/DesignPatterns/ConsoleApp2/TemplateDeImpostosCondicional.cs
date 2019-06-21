using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
<<<<<<< HEAD
        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }

        public TemplateDeImpostoCondicional() : base() { }



        public override double Calcula (Orçamento orçamento)
=======
        protected TemplateDeImpostosCondicional()
        {
        }

        protected TemplateDeImpostosCondicional(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        private double Calcula (Orçamento orçamento)
>>>>>>> c8a0aa5629f957749de162c43bf616e0cd7ef943
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
