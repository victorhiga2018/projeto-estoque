using MediatR;
using projeto_estoque.Application.Entitys.Responses;

namespace projeto_estoque.Application.Entitys.Commands
{
    public class CadastroProdutoCommand : IRequest<CadastroProdutoResponse>
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public double Peso { get; set; }
        public double Tamanho { get; set; }
        public string? Fabricante { get; set; }
        public string? Origem { get; set; }
        public DateTime Validade { get; set; }
    }
}
