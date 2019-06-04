using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Guardando_valor_de_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 2;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            string parcela_1 = "10";
            string parcela_2 = "20";

            Console.WriteLine(parcela_1 + parcela_2);
                
            Console.ReadLine();
      
        }
    }
}
