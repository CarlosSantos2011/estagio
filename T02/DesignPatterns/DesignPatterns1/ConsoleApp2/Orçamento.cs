using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Orçamento
    {
        public IEstadoDeUmOrcamento AplicaDescontoExtra { get; set; }
        public IEstadoDeUmOrcamento EstadoAtual { get; set; }
        public double Valor { get;  set; }
        public IList<Item> Itens { get; private set; }
        public Orçamento(double valor)



        { 
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void EmAprovacao()
        {
            throw new Exception("Em processo de aprovação");
        }


        public Orçamento()
        {
            this.EstadoAtual = new EmAprovacao();
        }
        //public void AplicaDescontoExtra( )
        //{
        //    EstadoAtual.AplicaDescontoExtra(this);
        //}
       
        public void AplicaDesconto(Orçamento orçamento)
        {
            EstadoAtual.AplicaDesconto(this);
        }


        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}