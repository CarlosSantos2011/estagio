using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {

        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }

        public TemplateDeImpostoCondicional() : base() { }

        public override double Calcula(Orçamento orçamento)
        {
            if (DeveUsarMaximaTaxacao(orçamento))
            {
                return MaximaTaxacao(orçamento);
            }
            else
            {
                return MinimaTaxacao(orçamento);
            }
            
        }

        public abstract bool DeveUsarMaximaTaxacao(Orçamento orcamento);
        public abstract double MaximaTaxacao(Orçamento orcamento);
        public abstract double MinimaTaxacao(Orçamento orcamento);













    }
       
    
}




