using Microsoft.EntityFrameworkCore.ChangeTracking;
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
            var promocaoDePascoa = new Promoção();
            promocaoDePascoa.Descrição = "Páscoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);
            promocaoDePascoa.Produtos.Add(new Produto());
            promocaoDePascoa.Produtos.Add(new Produto());
            promocaoDePascoa.Produtos.Add(new Produto());


            //compra de 6 pães

            var paoFrances = new Produto();
            paoFrances.Nome = "Pão Francês";
            paoFrances.PrecoUnitario = 0.40;
            paoFrances.Unidade = "Unidade";
            paoFrances.Categoria = "Padaria";



            var compra = new Compra();
            compra.Quantidade = 6;
            compra.Produto = paoFrances;
            compra.Preco = paoFrances.PrecoUnitario * compra.Quantidade;

            using (var contexto = new LojaContext())
            {
                

            
            }

          void ExibeEntries(IList<EntityEntry > entries)
            {
                foreach (var e in entries)
                {

                }
            }



        }
    }
}
