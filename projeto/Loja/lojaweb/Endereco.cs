using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lojaweb
{
    public class Endereco
    {
      public string Logradouro { get; private set; }

        public string NomeLogradouro { get; private set; }
        public double Numero { get; private set; }
        public string Cep { get; private set; }
        public string Bairro { get; private set; }
        public string Complemento { get; private set; }
        public string Cidade { get; private set; }

        public Endereco(string logradouro, string nomeLogradouro, double numero, string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            NomeLogradouro = nomeLogradouro;

        }
    }
}