using MediatR;
using Microsoft.AspNetCore.Mvc;
using projeto_estoque.Application.Entitys.Commands;
using projeto_estoque.Application.Produtos.Queries;
using projeto_estoque.Repositories;

namespace projeto_estoque.Controllers
{
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMediator _mediator;
        public ProdutoController(IProdutoRepository produtoRepository, IMediator mediator)
        {
            _produtoRepository = produtoRepository;
            _mediator = mediator;
        }

        [HttpPost]
        [Route("/cadastrarProduto")]
        public ActionResult CadastrarProduto([FromBody] CadastroProdutoCommand request)
        {
            var result = _mediator.Send(request);

            return Ok(result);
        }

        [HttpGet]
        [Route("/obterProdutos")]
        public async Task<ActionResult> Produtos()
        {
            var produtos = await _mediator.Send(new ConsultaProdutoCommand());

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
