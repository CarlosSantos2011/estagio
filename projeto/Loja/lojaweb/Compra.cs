using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lojaweb
{
    public class Compra
    {
        public int Id { get; private set; }
        public string Observacoes { get; private set; }
        public Fornecedor Fornecedor { get; private set; }

        public DateTime Data { get; private set; }
        public double Valor { get; private set; }
        public Funcionario Funcionario { get; set; }

        public Compra(int id, Fornecedor fornecedor, Funcionario funcionario, DateTime data, double valor)
        {
            Id = id;
            Fornecedor = fornecedor;
            Funcionario = funcionario;
            Valor = valor;
            Data = data;

        }

    }
}