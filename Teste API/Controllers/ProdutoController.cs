using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Teste_API.Models;
using Teste_API.Services;

namespace Teste_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _produtoService;
        private readonly AppDbContext _context;

        public ProdutoController(ProdutoService produtoService, AppDbContext context)
        {
            _produtoService = produtoService;
            _context = context;
        }

        // Testar conexão com o banco de dados
        [HttpGet("TestDatabase")]
        public IActionResult TestDatabase()
        {
            try
            {
                var users = _context.Users.ToList();
                return Ok(new { Message = "Conexão com o banco de dados funcionando!", Users = users });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Erro ao acessar o banco de dados.", Error = ex.Message });
            }
        }

        // Consultar todos os produtos
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> ObterTodosProdutos()
        {
            var produtos = _produtoService.ObterTodosProdutos();
            return Ok(produtos);
        }

        // Consultar produtos em estoque
        [HttpGet("em-estoque")]
        public ActionResult<IEnumerable<Produto>> ObterProdutosEmEstoque()
        {
            var produtos = _produtoService.ObterProdutosEmEstoque();
            return Ok(produtos);
        }

        // Adicionar um novo produto
        [HttpPost]
        public ActionResult AdicionarProduto([FromBody] Produto produto)
        {
            _produtoService.AdicionarProduto(produto);
            return CreatedAtAction(nameof(ObterTodosProdutos), new { id = produto.Id }, produto);
        }

        // Atualizar o estoque de um produto
        [HttpPut("{id}")]
        [Authorize(Roles = "Gerente,Funcionario")]  // Apenas Gerente ou Funcionário
        public ActionResult AtualizarEstoque(int id, [FromBody] int quantidade)
        {
            _produtoService.AtualizarEstoque(id, quantidade);
            return NoContent();
        }

        // Excluir um produto
        [HttpDelete("{id}")]
        [Authorize(Roles = "Gerente")]  // Apenas Gerente
        public ActionResult ExcluirProduto(int id)
        {
            _produtoService.ExcluirProduto(id);
            return NoContent();
        }
    }
}
