using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Compra
    {
        public string observacoes;

        private Fornecedor fornecedor { get; set; }
        private DateTime data { get;  set; }
        public double valor;
        private Funcionario funcionario { get; set; }
        public int iD;
        public Produto produto { get; private set; }

        public Compra(Fornecedor Fornecedor, DateTime Data, double Valor, Funcionario Funcionario, int Id)

        {
            this.fornecedor = Fornecedor;
            this.data = Data;
            this.valor = Valor;
            this.funcionario = Funcionario;
            this.iD = Id;
        }
    }
}