using MediatR;

namespace projeto_estoque.Application.Produtos.Commands
{
    public class AtualizaProdutoCommand : IRequest<string>
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
