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
            using (var contexto2 = new LojaContext())
            {
                var promocao = contexto2
                    .Promocoes
                    .Include(p => p.Produtos)
                    .ThenInclude
                    .ThenInclude(pp => pp.Produto)
                    .FirstOrDefault();

                Console.WriteLine("\nMotrando os produtos da promoção...");
                foreach (var item in promocao.Produtos)
                {
                    Console.WriteLine(item.Produto);
                }

            }

        private static void incluirpromocao()
        {
            using (var contexto = new LojaContext())
            {
                var promocao = new Promoção();
                promocao.Descrição = "Queima Total 2017";
                promocao.DataInicio = new DateTime(2017, 1, 1);
                promocao.DataTermino = new DateTime(2017, 1, 31);

                var produtos = contexto
                    .Produtos
                    .Where(p => p.Categoria == "Bebidas")
                    .ToList();


                foreach (var item in produtos)
                {
                    promocao.IncluiProduto(item);
                }
                contexto.Promocoes.Add(promocao);

                contexto.SaveChanges();

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






        
    
