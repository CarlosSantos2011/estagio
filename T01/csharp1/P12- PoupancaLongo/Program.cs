﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12__PoupancaLongo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for(int contadorAno = 1; contadorAno <=5; contadorAno++)
            {
                for(int contadorMes = 1; contadorMes <=12; contadorAno++)
                {
                    valorInvestido *= fatorRendimento;
                }
                    fatorRendimento += 0.0010;

            }
            Console.WriteLine("Tempo de investimento foi de" + contadorAno);
            Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido);

            Console.ReadLine();
        }
    }
}
