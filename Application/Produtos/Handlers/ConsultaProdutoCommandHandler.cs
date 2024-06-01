using AutoMapper;
using MediatR;
using projeto_estoque.Application.Entitys.Responses;
using projeto_estoque.Application.Entitys.Models;
using projeto_estoque.Repositories;
using projeto_estoque.Application.Produtos.Queries;

namespace projeto_estoque.Application.Entitys.Handlers
{
    public class ConsultaProdutoCommandHandler : IRequestHandler<ConsultaProdutoCommand, ConsultaProdutosResponse>
    {
        private readonly IProdutoRepository _produtoRepository;

        public ConsultaProdutoCommandHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<ConsultaProdutosResponse> Handle(ConsultaProdutoCommand request, CancellationToken cancellationToken)
        {
            var produtos = await _produtoRepository.ObterTodos();

            return new ConsultaProdutosResponse(produtos.Select(p => (ConsultaProdutoResponse)p));
        }
    }
}
