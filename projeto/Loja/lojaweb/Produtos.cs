using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lojaweb
{
    public class Produtos
    {
        public int Id { get; set; }

        public string Modelo { get;  set; }

        public string Nome { get; set; }

        public float Valor { get; set; }

        public int TempoGarantia { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public int Tipo { get; set; }
    }
}