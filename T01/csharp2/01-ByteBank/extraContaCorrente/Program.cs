using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraConta = new ContaCorrente();

            primeiraConta.saldo = 200.0;
            Console.WriteLine("Seu saldo é de " + primeiraConta.saldo);

            primeiraConta.saldo += 100;
            Console.WriteLine(primeiraConta.saldo);

            ContaCorrente segundaConta = new ContaCorrente();

            segundaConta.saldo = 50;

            Console.WriteLine("primeira conta tem " + primeiraConta.saldo);
            Console.WriteLine("segunda conta tem " + segundaConta.saldo);
            




            Console.ReadLine();
        }
    }
}
