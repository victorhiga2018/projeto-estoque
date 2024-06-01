using Microsoft.EntityFrameworkCore;
using projeto_estoque.Models;

namespace projeto_estoque.Infrastructure.Context
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {

        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProdutoContext).Assembly);
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
