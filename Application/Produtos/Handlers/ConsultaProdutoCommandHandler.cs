using AutoMapper;
using MediatR;
using projeto_estoque.Application.Entitys.Responses;
using projeto_estoque.Application.Entitys.Models;
using projeto_estoque.Repositories;
using projeto_estoque.Application.Produtos.Commands;
using projeto_estoque.Application.Produtos.Queries;

namespace projeto_estoque.Application.Entitys.Handlers
{
    public class ConsultaProdutoCommandHandler : IRequestHandler<ConsultaProdutoCommand, ConsultaProdutosQuery>
    {
        private readonly IProdutoRepository _produtoRepository;

        public ConsultaProdutoCommandHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<ConsultaProdutosQuery> Handle(ConsultaProdutoCommand request, CancellationToken cancellationToken)
        {
            var produtos = await _produtoRepository.ObterTodos();

            return new ConsultaProdutosQuery(produtos.Select(p => (ConsultaProdutoQuery)p));
        }
    }
}
