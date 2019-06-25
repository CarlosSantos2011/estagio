using DesignPatterns2.Aula4;

namespace DesignPatterns2
{
    public class Subtracao : IExpressao
    {
        public IExpressao Esquerda;
        public IExpressao Direita;

        public Subtracao (IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeSubtracao(this);
        }

        public int Avalia()
        {
            int resultadoDaEsquerda = Esquerda.Avalia();
            int resultadoDaDireita = Direita.Avalia();
            return resultadoDaEsquerda - resultadoDaDireita;
        }
    }
}