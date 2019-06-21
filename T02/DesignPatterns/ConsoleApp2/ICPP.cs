using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ICPP : TemplateDeImpostoCondicional
    {
<<<<<<< HEAD
        public ICPP() : base() { }
        public ICPP(Imposto outroImposto) : base(outroImposto) { }
=======
        public override double Calcula(Orçamento orçamento)
        {
            throw new NotImplementedException();
        }

>>>>>>> c8a0aa5629f957749de162c43bf616e0cd7ef943
        public override bool DeveUsarMaximaTaxacao(Orçamento orçamento)
        {
            return orçamento.Valor >= 500;
        }
        public override double MaximaTaxacao(Orçamento orçamento)
        {
            return orçamento.Valor * 0.07;
        }
        public override double MinimaTaxacao(Orçamento orçamento)
        {
            return orçamento.Valor * 0.05;
        }
    }
}
