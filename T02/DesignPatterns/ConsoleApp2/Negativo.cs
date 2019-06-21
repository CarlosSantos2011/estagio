using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Negativo
    {
        void Saca (Conta conta, double Valor)
        {
            throw new Exception("Sua conta está em vermelho, não pode sacar");
                      
        }
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0) conta.Estado = new Positivo();
        }
    }
}
