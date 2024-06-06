using MediatR;

namespace projeto_estoque.Application.Produtos.Commands
{
    public class DeletaProdutoPorIdCommand : IRequest<string>
    {
        public Guid Id { get; set; }
    }
}
