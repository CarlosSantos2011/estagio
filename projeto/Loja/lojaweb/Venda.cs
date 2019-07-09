using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lojaweb
{
    public class Venda
    {
        public int Id { get; private set; }
        public DateTime Data { get; private set; }
        public string FormaDePagamento { get; private set; }
        public double Desconto { get; private set; }
        public Clientes Cliente { get; private set; }
        public Funcionario Funcionario { get; private set; }
        public double Valor { get; private set; }
        public Venda(int id, DateTime data, string formaDePagamento, Clientes cliente, Funcionario funcionario, double valor)
        {
            id = Id;
            data = Data;
            formaDePagamento = FormaDePagamento;
            cliente = Cliente;
            funcionario = Funcionario;
            valor = Valor;
      
        }
       
    }
}