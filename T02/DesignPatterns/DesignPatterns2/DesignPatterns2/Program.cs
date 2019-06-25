using DesignPatterns2.Aula3;
using DesignPatterns2.Aula4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{
    class Program 
    {
        static void Main(string[] args)
        {

            //IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            //IExpressao direita = new Soma(new Numero(2), new Numero(10));

            //IExpressao conta = new Soma(esquerda, direita);

            //int resultado = conta.Avalia();

            Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(20)); // 10 + 20

            Func<int> interpreter = Expression.Lambda<Func<int>>(soma).Compile();
            int resultado = interpreter();

            Console.WriteLine(resultado);
        }    
    }
}
