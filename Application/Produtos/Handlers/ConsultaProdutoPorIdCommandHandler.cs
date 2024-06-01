using AutoMapper;
using MediatR;
using projeto_estoque.Application.Produtos.Commands;
using projeto_estoque.Application.Produtos.Queries;
using projeto_estoque.Repositories;

namespace projeto_estoque.Application.Produtos.Handlers
{
    public class ConsultaProdutoPorIdCommandHandler : IRequestHandler<ConsultaProdutoPorIdCommand, ConsultaProdutoPorIdQuery>
    {

        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ConsultaProdutoPorIdCommandHandler(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;

        }

        public async Task<ConsultaProdutoPorIdQuery> Handle(ConsultaProdutoPorIdCommand request, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepository.ObterPorId(request.Id);
            var result = _mapper.Map<ConsultaProdutoPorIdQuery>(produto);

            return result;
        }
    }
}
