using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lojaweb
{
    public class Estoque
    {
        public Produtos Produtos { get; private set; }
        public Compra Compra { get; private set; }
        public Venda Venda { get; private set; }
        public Venda Saida { get; private set; }
        public Compra Entrada { get; private set; }
        public bool Garantia { get; private set; }
        public string TipoMovimentacao { get; private set; }

        public Estoque(Produtos produto, Compra compra, Venda venda, Venda saida, Compra entrada, bool garantia, string tipoMovimentacao)

        {
            produto = Produtos;
            compra = Compra;
            saida = Venda;
            entrada = Compra;
            venda = Venda;
            garantia = Garantia;
            tipoMovimentacao = TipoMovimentacao;
        }

    }
}