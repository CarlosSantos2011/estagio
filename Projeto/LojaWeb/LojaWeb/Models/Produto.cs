namespace WebLoja2.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Nome { get; set; }

        public float Valor { get; set; }

        public int TempoGarantia { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public int Tipo { get; set; }
    }

}