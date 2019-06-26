using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula7
{
    public class PagaPedido : IComando
    {
        public Pedido pedido;

        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            pedido.Paga();
        }
    }
}
