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
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Orçamento orçamento = new Orçamento(50.00);
            CalculaImposto calculador = new CalculaImposto();

            calculador.RealizaCalculo(orçamento, iss);
            calculador.RealizaCalculo(orçamento, icms);

            Orçamento reforma = new Orçamento(3000.0);

            Imposto novoImposto = new ICCC();
            Console.WriteLine(novoImposto.Calcula(reforma));
            Console.ReadLine();
        }
       

    }
}
