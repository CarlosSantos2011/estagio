﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class Moderado : Investimento
    {
        public double Calcula (Conta conta)
        {
            return conta.Saldo * 0.007;
        }
            

    }
}
