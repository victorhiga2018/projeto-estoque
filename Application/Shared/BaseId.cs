namespace projeto_estoque.Application.Shared
{
    public class BaseId
    {
        public Guid Id { get; set; }
        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }
}
