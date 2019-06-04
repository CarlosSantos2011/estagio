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
            try
            {
                CarregarContas();
            }
            catch(Exception )
            {
                Console.WriteLine("Catch no metodo Main");
            }



            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }
        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("Teste.txt"))
            {

                
                leitor.LerProximaLinha();
            }
            ////-------------------------------------------


            //LeitorDeArquivo leitor = null;


            //try
            //{
            //    new LeitorDeArquivo("contas1.txt");

            //    leitor.LerProximaLinha();
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
            

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


