using lojaweb;
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
            Produtos produto1 = new Produtos();
            produto1.Id = 1;
            produto1.Nome = "Celular";

            Console.WriteLine("{0} - {1}", produto1.Id, produto1.Nome);

            Console.ReadLine();
        }
    }
}
