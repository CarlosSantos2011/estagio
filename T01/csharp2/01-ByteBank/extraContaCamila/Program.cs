﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraContaCamila
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaCamila = new ContaCorrente();
            contaDaCamila.titular = new Cliente();

            contaDaCamila.titular.nome = "Camila";



            Console.ReadLine();
        }

    }
}
