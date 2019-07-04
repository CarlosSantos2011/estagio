using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Estoque
    {
        public Produto Produto { get; private set; }
        public Compra Compra { get; private set; }
        public Venda Venda { get; private set; }
        private int saida { get; set; }
        private int entrada { get; set; }
        private bool garantia;
        private string tipoMovimentacao;

        public Estoque()
        {

        }
      public void lancaEstoque()
        {
           
        }
    }
}