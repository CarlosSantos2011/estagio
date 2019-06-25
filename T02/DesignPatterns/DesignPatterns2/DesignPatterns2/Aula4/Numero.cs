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

        public string Valor { get; internal set; }

        private string numero1;

        public string GetNumero()
        {
            return numero1;
        }

        internal void SetNumero(string value)
        {
            numero1 = value;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeNumero(this);
        }

        public int Avalia()
        {
            return numero;
        }
    }
}