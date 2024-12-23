﻿using Microsoft.AspNetCore.Authorization;
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

        // Consultar todos os produtos
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> ObterTodosProdutos()
        {
            var produtos = _produtoService.ObterTodosProdutos();
            return Ok(produtos);
        }

        // Consultar produtos em estoque
        [HttpGet("em-estoque")]
        public IActionResult GetProdutosEmEstoque()
        {
            var produtosEmEstoque = _context.Produtos
                .Where(p => p.Status == "em-estoque")
                .ToList();

            return Ok(produtosEmEstoque);
        }

        // Adicionar um novo produto
        [HttpPost]
        public ActionResult AdicionarProduto([FromBody] Produto produto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Retorna os erros de validação automaticamente.
            }

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
