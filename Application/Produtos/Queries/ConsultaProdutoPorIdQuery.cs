namespace projeto_estoque.Application.Produtos.Queries
{
    public class ConsultaProdutoPorIdQuery
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
