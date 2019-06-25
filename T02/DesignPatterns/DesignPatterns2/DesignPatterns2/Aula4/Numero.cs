using DesignPatterns2.Aula4;

namespace DesignPatterns2
{
    public class Numero : IExpressao
    {
        private int numero;

        public Numero(int numero)
        {
            this.numero = numero;
        }

        public int Avalia()
        {
            return numero;
        }
    }
}