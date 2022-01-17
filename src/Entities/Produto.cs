namespace LaBrasa.Shared.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Catergoria { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int QuantidadeMinima { get; set; }
        public int QuantidadeAdicionar { get; set; }
        public double PrecoCusto { get; set; }
        public double PrecoVenda { get; set; }
    }
}
