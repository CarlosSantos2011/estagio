using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Conta
    {
        public double Saldo{ get; private set; }
        public int Valor { get; internal set; }
        public object DataAbertura { get; internal set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
            

        
    }
}
