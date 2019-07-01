namespace Alura.LeilaoOnline.Core
{
    public class Interessada
    {
        public string Nome { get; }
        public Leilao leilao { get; }

        public Interessada(string nome, Leilao leilao)
        {
            Nome = nome;
            this.leilao = leilao;
        }
    }
}
