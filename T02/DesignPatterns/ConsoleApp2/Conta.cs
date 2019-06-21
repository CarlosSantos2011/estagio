using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Conta
    {
        public double Saldo { get; private set; }

        interface IEstadoDaConta
        {
            void Saca(Conta c, double valor);
            void Deposita(Conta c, double valor);
        }
        class Positivo : IEstadoDaConta
        {
            public void Saca(Conta c, double valor)
            {
                c.Saldo -= valor;
            }
            public void Deposita(Conta c, double valor)
            {
                c.Saldo += valor;
            }
        }
    }
}
