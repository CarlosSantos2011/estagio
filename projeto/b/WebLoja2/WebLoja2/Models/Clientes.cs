using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class Clientes : Pessoa
    {

        public string Cpf { get;  set; }
        public  Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
        public Clientes(string nome, int id, string cpf)
        {
            Nome = nome;
            Id = id;
            Cpf = cpf;
        }
        public void Compra()
        {
            Produtos novaCompra = new Produtos();

        }

    }
}
