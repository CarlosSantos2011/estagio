using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EnviadorDeSms : IAcoesAposGerarNota
    {
        public void Executa (NotaFiscal nf)
        {
            Console.WriteLine("Sms");
        }

    }
}
