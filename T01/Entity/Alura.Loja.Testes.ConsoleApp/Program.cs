using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                var cliente = contexto
                    .Clientes
                    .Include(c => c.EnderecoDeEntrega)
                    .FirstOrDefault();

                Console.WriteLine($"Endereço de entrega: {cliente.EnderecoDeEntrega.Logradouro}");

                var produto = contexto
                    .Produtos
                    .Where(p => p.Id == 9004)
                    .FirstOrDefault();

                contexto.Entry(produto)
                    .Collection(p => p.Compras)
                    .Query()
                    .Where(c => c.Preco > 10)
                    .Load();

                Console.WriteLine($"Mostrando as compras do produto {produto.Nome}");
                foreach (var item in produto.Compras)
                {
                    Console.WriteLine("\t" + item);
                }
            }
        }



        //private static void MuitoPraMuitos()
        //{
        //    var p1 = new Produto() { Nome = "Suco de Laranja", Categoria = "Bebidas", PrecoUnitario = 8.79, Unidade = "Litros" };
        //    var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario = 12.45, Unidade = "Gramas" };
        //    var p3 = new Produto() { Nome = "Macarrão", Categoria = "Alimentos", PrecoUnitario = 4.23, Unidade = "Gramas" };

        //    var promocaoDePascoa = new Promoção();
        //    promocaoDePascoa.Descrição = "Páscoa Feliz";
        //    promocaoDePascoa.DataInicio = DateTime.Now;
        //    promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);

        //    promocaoDePascoa.IncluiProduto(p1);
        //    promocaoDePascoa.IncluiProduto(p2);
        //    promocaoDePascoa.IncluiProduto(p3);

        //    using (var contexto = new LojaContext())
        //    {


        //    }

    }






        
    
