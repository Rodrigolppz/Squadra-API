using Teste_API.Models;

namespace Teste_API.Services
{
    public class ProdutoService
    {
        private List<Produto> _produtos = new List<Produto>();

        public List<Produto> ObterTodosProdutos()
        {
            return _produtos;
        }

        public List<Produto> ObterProdutosEmEstoque()
        {
            return _produtos.Where(p => p.Status == "Em estoque").ToList();
        }

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public void AtualizarEstoque(int id, int quantidade)
        {
            var produto = _produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                produto.QuantidadeEstoque = quantidade;
            }
        }

        public void ExcluirProduto(int id)
        {
            var produto = _produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                _produtos.Remove(produto);
            }
        }
    }
}
