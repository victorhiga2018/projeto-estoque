using MediatR;
using projeto_estoque.Application.Entitys.Models;

namespace projeto_estoque.Application.Produtos.Queries
{
    public record ConsultaProdutoCommand : IRequest<ConsultaProdutosResponse>;

    public record ConsultaProdutoResponse(Guid id, string? nome, double preco, double peso, double tamanho, string? fabricante, string? origem, DateTime validade)
    {
        public static explicit operator ConsultaProdutoResponse(Produto produto) => new(produto.Id, produto.Nome, produto.Preco, produto.Peso, produto.Tamanho, produto.Fabricante, produto.Origem, produto.Validade);
    }

    public record ConsultaProdutosResponse(IEnumerable<ConsultaProdutoResponse> produtos);
}
