using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            carlos.Nome = "Carlos";
      
            carlos.AumentarSalario();

            Console.WriteLine("Novo salario do Carlos " + carlos.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);


            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor(5000, "454.658.148-3");
            roberta.Nome = "Roberta"; 
           
            

           Funcionario robertaTeste = roberta;

            roberta.AumentarSalario();

            Console.WriteLine("O salario de Roberta é de " + roberta.Salario);

            Console.WriteLine("Bonificação de referencia de um funcionário: " + roberta.GetBonificacao());

            Console.WriteLine("Bonificação de uma referencia de Diretor: " + roberta.GetBonificacao());

            gerenciador.Registrar(roberta);

             Console.WriteLine(Funcionario.TotalDeFuncionarios);


            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
            
        }
    }
}
