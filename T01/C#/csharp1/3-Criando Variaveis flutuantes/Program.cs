using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Criando_Variaveis_flutuantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 3. Criando variáveis ponto flutuante");

            double salario;
            salario = 1270.50;

            Console.WriteLine("Seu salário é de " + salario + "!");

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine("Sua idade é " + idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5 / 3 =" + idade);

            Console.WriteLine("A aplicação terminou, tecle enter para fechar");
            Console.ReadLine();
     
        }
    }
}
