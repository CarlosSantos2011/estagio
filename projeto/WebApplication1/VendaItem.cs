using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class VendaItem
    {
        private double valorTotal;
        private int quantidade;
        public Venda venda { get;  private set; }
        private double valorUnitario;
        private double descontoPorItem;

        public VendaItem(double ValorTotal, int Quantidade, Venda Venda, double ValorUnitario, double DescontoPorItem)
        {
            this.valorTotal = ValorTotal;
            this.quantidade = Quantidade;
            this.venda = Venda;
            this.valorUnitario = ValorUnitario;
            this.descontoPorItem = DescontoPorItem;
        }
        
    }
  
}