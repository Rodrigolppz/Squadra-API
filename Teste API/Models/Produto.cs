using System.ComponentModel.DataAnnotations;

namespace Teste_API.Models
{
    public class Produto
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Status { get; set; }  // Em estoque, esgotado

        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Preco { get; set; }

        
        public int QuantidadeEstoque { get; set; }


    }
}
