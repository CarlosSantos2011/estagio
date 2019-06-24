using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class CriadorDeNotaFiscal
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }
        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        private IList<IAcoesAposGerarNota> todasAcoesASeremExecutadas = new List<IAcoesAposGerarNota>();
        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);

           foreach(IAcoesAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;

        }
        public void AdicionaAcao(IAcoesAposGerarNota acao)
        {
            this.todasAcoesASeremExecutadas.Add(acao);
        }
      
        public void ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
        }
        public void ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
        }
        public void ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
        }
        public void ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
        }
        public void NaDataAtual(DateTime data)
        {
            this.Data = data;
        }
        public CriadorDeNotaFiscal Com(ItemDaNota item)
        {
            this.todosItens.Add(item);
            this.valorTotal += item.Valor;
            this.impostos += item.Valor * 0.05;
            return this;
        }
    }
}