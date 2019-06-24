using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "Carlos";
            pessoa.Idade = 1;
            pessoa.Quantidade = 1;


            Pessoa pessoaMaisVelha = new Pessoa();
            pessoa.Nome = "João";
            pessoa.Idade = 19;


            if(pessoa.Idade >= 18 || pessoa.Quantidade >= 2)
            {
                Console.WriteLine(pessoa.Nome + " pode entrar");
            }
            else
            {
                Console.WriteLine("nao pode entrar");
            }
            Console.ReadLine();
         
        }
    }
}
