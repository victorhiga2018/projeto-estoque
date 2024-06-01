using Microsoft.AspNetCore.Mvc;
using projeto_estoque.Models;
using projeto_estoque.Repositories;

namespace projeto_estoque.Controllers
{
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpPost]
        [Route("/cadastrarProduto")]
        public ActionResult CadastrarProduto([FromBody] Produto produto)
        {
            _produtoRepository.Cadastrar(produto);

            return Ok("CADASTRADO COM SUCESSO!");
        }

        [HttpGet]
        [Route("/obterProdutos")]
        public async Task<ActionResult> Produtos()
        {
            var produtos = await _produtoRepository.ObterTodos();

            return Ok(produtos);
        }

        [HttpGet]
        [Route("/obterProdutoId/{id}")]
        public async Task<ActionResult> ProdutoPorId(Guid id)
        {
            var produto = await _produtoRepository.ObterPorId(id);
            return Ok(produto);
        }
    }
}
