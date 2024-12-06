using Teste_API.Models;

namespace Teste_API.Services
{
    public class ProdutoService
    {
        private readonly AppDbContext _context;

        public ProdutoService(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarProduto(Produto produto)
        {
            _context.Produtos.Add(produto); // Adiciona o produto ao banco de dados
            _context.SaveChanges(); // Salva as alterações no banco
        }

        public List<Produto> ObterTodosProdutos()
        {
            return _context.Produtos.ToList(); // Retorna todos os produtos
        }

        public List<Produto> ObterProdutosEmEstoque()
        {
            return _context.Produtos.Where(p => p.Status == "Em estoque").ToList(); // Filtra produtos com status "Em estoque"
        }

        public void AtualizarEstoque(int id, int quantidade)
        {
            var produto = _context.Produtos.Find(id); // Busca o produto pelo ID
            if (produto != null)
            {
                produto.QuantidadeEstoque = quantidade;
                _context.SaveChanges(); // Atualiza o banco
            }
        }

        public void ExcluirProduto(int id)
        {
            var produto = _context.Produtos.Find(id); // Busca o produto pelo ID
            if (produto != null)
            {
                _context.Produtos.Remove(produto); // Remove o produto
                _context.SaveChanges(); // Salva as alterações
            }
        }
    }
}
