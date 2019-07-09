namespace lojaweb
{
    public class Fornecedor : Pessoas
    {
        public string Cnpj { get; private set; }
        public string RazaoSocial { get; private set; }

        public Fornecedor(int id, string nome, string cnpj, string razaoSocial)
        {
            Id = id;
            Nome = nome;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
        }
    }
}