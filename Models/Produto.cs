using projeto_estoque.Models.Shared;

namespace projeto_estoque.Models
{
    public class Produto : BaseId
    {
        public String Nome { get; set; }
        public double Peso { get; set; }
        public double Tamanho { get; set; }
        public String Fabricante { get; set; }
        public string Origem { get; set; }
        public DateTime Validade { get; set; }

    }
}
