using MediatR;
using projeto_estoque.Application.Produtos.Queries;

namespace projeto_estoque.Application.Produtos.Commands
{
    public class ConsultaProdutoPorIdCommand : IRequest<ConsultaProdutoPorIdQuery>
    {
        public Guid Id { get; set; }
    }
}
