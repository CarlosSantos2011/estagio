using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Produto
    { 
        public int iD;
        public string modelo;
        public int quantidade;
        public string tipo;
        public int tempoGarantia;
        public string nome;
        public string descricao;
        public double valor;

        public Produto ( int Id, string Modelo, int Quantidade, string Tipo, int TempoGarantia, string Nome, string Descricao, double Valor )
        {
            this.iD = Id;
            this.modelo = Modelo;
            this.quantidade = Quantidade;
            this.tipo = Tipo;
            this.tempoGarantia = TempoGarantia;
            this.nome = Nome;
            this.descricao = Descricao;
            this.valor = Valor;
        }


    }
    
}