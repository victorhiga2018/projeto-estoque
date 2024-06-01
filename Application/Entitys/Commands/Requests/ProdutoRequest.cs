using MediatR;
using projeto_estoque.Application.Entitys.Commands.Responses;

namespace projeto_estoque.Application.Entitys.Commands.Requests
{
    public class ProdutoCadastroRequest : IRequest<ProdutoCadastroResponse>
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Peso { get; set; }
        public double Tamanho { get; set; }
        public string Fabricante { get; set; }
        public string Origem { get; set; }
        public DateTime Validade { get; set; }
    }
}
