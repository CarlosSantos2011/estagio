using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversação_e_outros_tipos_numericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;
            // o int é um tipo de variavel que suporta valores até 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine("Seu salario é " + salarioEmInteiro);

            // o long é uma variavel de 64 bits
            long idade;
            idade = 130000000000000;
            Console.WriteLine(idade);

            // o short é uma variavel que suporta apenas 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);






            Console.WriteLine("Aplicação encerrada. Tecle enter para fechar");
            Console.ReadLine();
        }
    }
}
