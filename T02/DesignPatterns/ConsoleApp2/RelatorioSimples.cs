using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class RelatorioSimples : Relatorio
    {
        protected override void Cabeçalho()
        {
            Console.WriteLine("Banco Itaú");
        }
        protected override void Rodape()
        {
            Console.WriteLine("(47) 996994869");
        }
        protected override void Corpo(IList<Conta> conta)
        {
            foreach (Conta c in conta)
            Console.WriteLine("Contas");
        }

    }
}
