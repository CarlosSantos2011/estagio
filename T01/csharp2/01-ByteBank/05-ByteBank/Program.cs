using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "desenvolvedoraC#";
            //gabriela.cpf = "434.562.878 - 20";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;
            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "434.562.878-29";
            conta.titular.profissao = "Desenvolvedora C#";
        

            conta.saldo = 500;
            conta.agencia = 564;
            conta.numero = 564427;

            conta.titular.nome = "Gabriela Costa";

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);





            Console.ReadLine();
        }

    }
}
