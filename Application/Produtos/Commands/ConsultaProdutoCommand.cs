using MediatR;
using projeto_estoque.Application.Entitys.Models;
using projeto_estoque.Application.Produtos.Queries;

namespace projeto_estoque.Application.Produtos.Commands
{
    public record ConsultaProdutoCommand : IRequest<ConsultaProdutosQuery>;

   
}
