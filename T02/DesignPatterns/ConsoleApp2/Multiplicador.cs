using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Multiplicador : IAcoesAposGerarNota


    {
        public double Fator { get; private set; }
        public Multiplicador(double fator) { this.Fator = fator; }


        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.ValorBruto * this.Fator);
        }
    }
}
