using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class IKCV : TemplateDeImpostoCondicional
    
    {
        public IKCV() : base() { }

        public IKCV(Imposto outroImposto) : base(outroImposto) { }


        public override double Calcula(Orçamento orçamento)
        {
            throw new NotImplementedException();
        }


        public override bool DeveUsarMaximaTaxacao(Orçamento orçamento)
        {
            return orçamento.Valor >= 500 && TemItemMaiorQue100ReaisNo(orçamento);
        }
        public override double MaximaTaxacao(Orçamento orçamento)
        { 
                return orçamento.Valor * 0.10;
        }
        public override double MinimaTaxacao(Orçamento orçamento)
        {
            return orçamento.Valor * 0.06;
        }

        

        private bool TemItemMaiorQue100ReaisNo(Orçamento orçamento)
        {
            foreach(Item item in orçamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;
        }
    }
}
