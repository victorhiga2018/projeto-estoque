using AutoMapper;
using MediatR;
using projeto_estoque.Application.Entitys.Models;
using projeto_estoque.Application.Produtos.Commands;
using projeto_estoque.Repositories;

namespace projeto_estoque.Application.Produtos.Handlers
{
    public class AtualizaProdutoCommandHandler : IRequestHandler<AtualizaProdutoCommand, string>
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;
        public AtualizaProdutoCommandHandler(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }
        public async Task<string> Handle(AtualizaProdutoCommand request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<Produto>(request);

            await _produtoRepository.Atualizar(result);

            return await Task.FromResult("ATUALIZADO COM SUCESSO!");
        }
    }
}
