using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }
        public double Calcula(Orçamento orcamento)
        {
            if (aconteceuVendaCasadaEm(orcamento)) return orcamento.Valor * 0.05;
            else return Proximo.Desconta(orcamento);
        }

        public double Desconta(Orçamento orçamento)
        {
            throw new NotImplementedException();
        }

        private bool aconteceuVendaCasadaEm(Orçamento orcamento)
        {
            return existe("CANETA", orcamento) && existe("LAPIS", orcamento);
        }

        private bool existe(String nomeDoItem, Orçamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem)) return true;
            }
            return false;
        }

    }
}