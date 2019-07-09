using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lojaweb
{
    public class Clientes : Pessoas
    {
        public string Cpf { get; private set; }

        public Clientes(string nome, int id, string cpf)
        {
            Nome = nome;
            Id = id;
            Cpf = cpf;
        }
    }
}