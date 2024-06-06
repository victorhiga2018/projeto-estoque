using Microsoft.EntityFrameworkCore;
using projeto_estoque.Application.Entitys.Models;

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
