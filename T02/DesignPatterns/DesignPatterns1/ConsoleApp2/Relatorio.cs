using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Relatorio
    {
        protected abstract void Cabeçalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<Conta> conta);

        public void Imprime (IList<Conta> contas)
        {
            Cabeçalho();
            Corpo(contas);
            Rodape();
            
        }

    }
}
