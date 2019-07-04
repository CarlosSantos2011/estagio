using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Venda
    {
        public DateTime Date { get; private set; } 
        protected Clientes Cliente { get; private set; }
        public double formaDePagamento;
        public int iD;
        public double desconto;
        public double valor;
        protected Funcionario Funcionario { get; private set; }
        public Produto Produto { get; private set; }

    }
}