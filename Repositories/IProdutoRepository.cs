using projeto_estoque.Models;

namespace projeto_estoque.Repositories
{
    public interface IProdutoRepository
    {
        void Cadastrar(Produto produto);
        void Atualizar(Produto produto);
        void Remover(int id);
        Task<IEnumerable<Produto>> ObterTodos();
        Task<Produto?> ObterPorId(Guid id);
    }
}
