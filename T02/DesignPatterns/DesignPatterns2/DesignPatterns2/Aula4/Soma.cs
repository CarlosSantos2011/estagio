using DesignPatterns2.Aula4;

namespace DesignPatterns2
{
    public class Soma : IExpressao
    {

        public IExpressao Esquerda;
        public IExpressao Direita;

        public Soma(IExpressao Esquerda, IExpressao Direita)
        {
            this.Esquerda = Esquerda;
            this.Direita = Direita;
        }

       

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeSoma(this);
        }

        public int Avalia()
        {
            int resultadoDaEsquerda = Esquerda.Avalia();
            int resultadoDaDireita = Direita.Avalia();
            return resultadoDaEsquerda + resultadoDaDireita;
        }
    }
}