using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ItemDaNota
    {
        public String Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota(String Nome, double Valor)
        {
            this.Nome = Nome;
            this.Valor = Valor;
        }
    }
}
