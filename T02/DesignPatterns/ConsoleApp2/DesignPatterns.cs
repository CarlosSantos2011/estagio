using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(String[] args)
        {
            CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();
            criador.ParaEmpresa("empresa");
            criador.ComCnpj("23213");
            criador.ComItem(new ItemDaNota("item 1", 100.00));
            criador.ComItem(new ItemDaNota("item 2", 50.00));

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.ReadKey();
        }    

    }
}




    
