using projeto_estoque.Application.Shared;

namespace projeto_estoque.Application.Entitys.Models
{
    public class Produto : BaseId
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Peso { get; set; }
        public double Tamanho { get; set; }
        public string Fabricante { get; set; }
        public string Origem { get; set; }
        public DateTime Validade { get; set; }
    }
}
