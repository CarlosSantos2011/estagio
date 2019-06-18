﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ICPP : TemplateDeImpostosCondicional
    {
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
