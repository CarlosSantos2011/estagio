﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
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
            var fulano = new Cliente();
            fulano.Nome = "Fulaninho de tal";
            fulano.EnderecoDeEntrega = new Endereco()
            {
                Numero = 12,
                Logradouro = "Rua 2",
                Complemento = "sobrado",
                Bairro = "Centro",
                Cidade = "Blumenau"


            };
            using (var contexto = new LojaContext())
            {
                contexto.Clientes.Add(fulano);
                contexto.SaveChanges();
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
}