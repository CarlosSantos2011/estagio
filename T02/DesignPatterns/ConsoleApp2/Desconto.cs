﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public interface Desconto
    {
        double Desconta(Orçamento orçamento);
        Desconto Proximo {  get;  set; }

       
    }
}
