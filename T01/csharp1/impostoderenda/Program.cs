using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impostoderenda
{
    class Program
    {
        static void Main(string[] args)
        {
            // De 1900.0 até 2800.0 o IR é de 7.5% e pode deduzir na declaração o valor de 142.
            // De 2800.01 até 3751.0 o IR é de 15% e pode deduzir 350
            // de 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir 636
            double salario = 3800.0;

            if (salario >= 1900.0 && salario <=2800.0)
            {
                Console.WriteLine("A sua aliquota é de 7.5%");
                Console.WriteLine("Pode deduzir 142,00$");
            }
            if (salario >= 2800.01 && salario <= 3751)
            {
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("Pode deduzir $350,00");
            }
            if (salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("A sua aliquota é de 22.5%");
                Console.WriteLine("Pode deduzir $636,00");
            }
            
        }
    }
}
