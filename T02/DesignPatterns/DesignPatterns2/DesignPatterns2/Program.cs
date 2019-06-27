using DesignPatterns2.Aula3;
using DesignPatterns2.Aula4;
using DesignPatterns2.Aula6;
using DesignPatterns2.Aula7;
using DesignPatterns2.Aula8;
using DesignPatterns2.Aula9;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

            //Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(20)); // 10 + 20

            //Func<int> interpreter = Expression.Lambda<Func<int>>(soma).Compile();
            //int resultado = interpreter();

            //Console.WriteLine(resultado);

            //Pedido pedido1 = new Pedido("Mauricio", 150.0);
            //Pedido pedido2 = new Pedido("Marcelo", 250.0);

            //FilaDeTrabalho fila = new FilaDeTrabalho();

            //fila.Adiciona(new PagaPedido(pedido1));
            //fila.Adiciona(new PagaPedido(pedido2));
            //fila.Adiciona(new FinalizaPedido(pedido1));

            //fila.Processa();

            //Console.WriteLine(pedido1);

            //Console.ReadLine();
            //Cliente cliente = new Cliente();
            //cliente.Nome = "carlos";
            //cliente.Endereco = "Rua Alceste";
            //cliente.DataDeNascimento = DateTime.Now;

            //GeradorXml gerador = new GeradorXml();
            //String xml = gerador.GeraXml(cliente);

            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            Cliente cliente = facade.BuscaCliente(cpf);

            var fatura = facade.CriaFatura(cliente, 5000);
            facade.GeraCobranca(tipo.Boleto, fatura);

        }
    }

}