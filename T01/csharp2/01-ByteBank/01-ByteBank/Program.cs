﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.agencia = 863;
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100.0;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agência " + contaDaGabriela.agencia);
            Console.WriteLine("Número " + contaDaGabriela.numero);
            Console.WriteLine("Saldo " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;

            Console.ReadLine();
        }
    }
}
