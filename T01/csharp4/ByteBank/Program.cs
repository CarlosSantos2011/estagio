using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {

        static void Main(string[] args)
        {
            CarregarContas();

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }
        private static void CarregarContas()
        {
            LeitorDeArquivo leitor = null;


            try

            {
                new LeitorDeArquivo("contas1.txt");

                leitor.LerProximaLinha();
            }
            catch (IOException)
            {
                Console.WriteLine("Exceção do tipo IO capturada e tratada");
            }
            finally
            {
                if (leitor != null)
                {
                    leitor.Fechar();
                }
            }
            

        }
        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                // conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }






        }
    }
}


