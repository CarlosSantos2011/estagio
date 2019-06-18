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
            Imposto imposto = new ISS(new ICMS());
            Orçamento orçamento = new Orçamento(500.0);
            Console.WriteLine(imposto.Calcula(orçamento));


            Console.ReadLine();
        }
       

    }
}
