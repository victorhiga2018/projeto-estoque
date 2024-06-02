using projeto_estoque.Application.Entitys.Models;

namespace projeto_estoque.Repositories
{
    public interface IProdutoRepository
    {
        void Cadastrar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
        Task<IEnumerable<Produto>> ObterTodos();
        Task<Produto?> ObterPorId(Guid id);
    }
}
