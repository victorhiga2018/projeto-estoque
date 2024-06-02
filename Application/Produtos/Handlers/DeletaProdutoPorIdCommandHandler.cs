using MediatR;
using projeto_estoque.Application.Produtos.Commands;
using projeto_estoque.Repositories;

namespace projeto_estoque.Application.Produtos.Handlers
{
    public class DeletaProdutoPorIdCommandHandler : IRequestHandler<DeletaProdutoPorIdCommand, string>
    {
        private readonly IProdutoRepository _produtoRepository;
        public DeletaProdutoPorIdCommandHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        
        public async Task<string> Handle(DeletaProdutoPorIdCommand request, CancellationToken cancellationToken)
        {
            await _produtoRepository.Remover(request.Id);
            return await Task.FromResult("REMOVIDO COM SUCESSO!");
        }
    }
}
