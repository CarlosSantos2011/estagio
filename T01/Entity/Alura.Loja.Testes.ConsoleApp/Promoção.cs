﻿
using System;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Promoção
    {
        public int Id { get; set; }
        public string Descrição { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataTermino { get; internal set; }
        public IList<Produto> Produtos { get; internal set; }
        
        internal void Include(Produto p1)
        {
        }
    }  
}
