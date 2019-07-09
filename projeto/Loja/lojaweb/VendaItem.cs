using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lojaweb
{
    public class VendaItem
    {
        public double ValorTotal { get; private set; }
        public int Quantidade { get; private set; }
        public Venda Venda { get; private set;}
        public Produtos Produto { get; private set; }
        public float ValorUnitario { get; private set; }
        public float DescontoPorItem { get; private set; }

        public VendaItem(Venda venda, Produtos produto, int quantidade, double valorTotal, float valorUnitario)
        {
            Venda = venda;
            Produto = produto;
            Quantidade = quantidade;
            ValorTotal = valorTotal;
            ValorUnitario = ValorUnitario;

        }
    }
}