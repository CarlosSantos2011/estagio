using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class CompraItem
    {
        public Compra compra { get; private set; }
        private int quantidade;
        private double descontoPorItem;
        private double valorUnitario;
        private double valorTotal;

        public CompraItem(Compra Compra, int Quantidade, double DescontoPorItem, double ValorUnitario, double ValorTotal)

        {
            this.compra = Compra;
            this.quantidade = Quantidade;
            this.descontoPorItem = DescontoPorItem;
            this.valorTotal = ValorTotal;
            this.valorUnitario = ValorUnitario;
        }
    }
}