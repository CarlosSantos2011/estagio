using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7");

            int idadeJoao = 17;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Joao possui mais de 18 anos de idade, pode entrar");
            }
            else
            {
                if (quantidadePessoas >=2)
                {
                    Console.WriteLine("Joao nao possui mais de 18 anos, mas está acompanhado");
                }
                else
                {
                    Console.WriteLine("Joao não possui 18 anos, não pode entrar");
                }
            }
                
        } 
    }
}

