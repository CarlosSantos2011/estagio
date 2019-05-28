using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Executando projeto 9 - Escopo");


                int idadeJoao = 18;             
                bool acompanhado = true;
                string mensagemAdicional;
               

                if (acompanhado == true)
                {
                   mensagemAdicional = "João está acompanhado";
                }
                else
                {
                   mensagemAdicional = "Joao não está acompanhado";
                }
                if (idadeJoao >= 18 && acompanhado == true)
                {
                    Console.WriteLine("Joao pode entrar");
                    Console.WriteLine(mensagemAdicional);
                }
                else
                {
                    Console.WriteLine("João não pode entrar");

                }

            }
            Console.ReadLine();
        }
    }
}
