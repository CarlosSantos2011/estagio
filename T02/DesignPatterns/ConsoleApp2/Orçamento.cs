﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  

    
    public class Orçamento
    {
        public double Valor { get; private set; }

        public Orçamento(double valor)
        {
            this.Valor = valor;
        }
    }
}
