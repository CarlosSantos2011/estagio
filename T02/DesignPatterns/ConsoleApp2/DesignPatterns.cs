using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Imposto imposto = new ISS(new ICMS());
            //Orçamento orçamento = new Orçamento(500.0);
            //Console.WriteLine(imposto.Calcula(orçamento));


            //Console.ReadLine();

            Orçamento reforma = new Orçamento(500.0);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime 475,00 pois descontou 5%
            reforma.Aprova(); // aprova nota!

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%

            reforma.Finaliza();

        }


    }
}
