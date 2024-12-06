namespace Teste_API.Models
{
    public class Produto
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }  // Em estoque, Indisponível
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }


    }
}
