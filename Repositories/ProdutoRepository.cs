using Microsoft.EntityFrameworkCore;
using projeto_estoque.Application.Entitys.Models;
using projeto_estoque.Infrastructure.Context;

namespace projeto_estoque.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoContext _context;

        public ProdutoRepository(ProdutoContext context)
        {
            _context = context;
        }

        public void Atualizar(Produto produto)
        {
            _context.Update(produto);
            _context.SaveChanges();
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            IEnumerable<Produto> produtos = await _context.Produtos.ToListAsync();
            return produtos;
        }

        public async Task<Produto?> ObterPorId(Guid id)
        {
            Produto? produto = await _context.Produtos.FindAsync(id);
            return produto; 
        }

        public void Remover(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }
    }
}
