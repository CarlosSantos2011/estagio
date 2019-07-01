using System;
using Alura.LeilaoOnline.Core;

namespace Alura.LeilaoOnline.ConsoleApp
{
    class Program
    {
        private static void Verifica (double esperado, double obtido)
        {

            if (esperado == obtido)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Teste ok");
            }
            else
            {
                Console.WriteLine("teste falhou");
            }
        }
        private static void LeilaoComVariosLances()
        {
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            //Arranje
            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(maria, 990);
       
            //Act
            leilao.TerminaPregao();

            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;

           
            
            
        }
        private static void LeilaoComApenasUmLance()
        {
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            

            //Arranje
            leilao.RecebeLance(fulano, 800);
            //Act
            leilao.TerminaPregao();

            var valorEsperado = 800;
            var valorObtido = leilao.Ganhador.Valor;

            Verifica(valorEsperado, valorObtido);
            Console.ReadLine();
        }



        
    
        static void Main(string[] args)
        {
            LeilaoComVariosLances();
            LeilaoComApenasUmLance();
            
        }
    }
}
