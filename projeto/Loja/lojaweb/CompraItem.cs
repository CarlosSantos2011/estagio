using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lojaweb
{
    public class CompraItem
    {
        public Compra Compra { get; private set; }
        public Produtos Produtos { get; private set; }
        public double DescontoPorItem { get; private set; }
        public int Quantidade { get; private set; }
        public float ValorUnitario { get; private set; }
        public double ValorTotal { get; private set; }

        public CompraItem( Compra compra, Produtos produtos, int quantidade, float valorUnitario, double valorTotal)
        {
            compra = Compra;
            produtos = Produtos;
            quantidade = Quantidade;
            valorUnitario = ValorUnitario;
            valorTotal = ValorTotal;
        }
    }
}