using Microsoft.EntityFrameworkCore;
using projeto_estoque.Models;
using System.Reflection.Metadata;

namespace projeto_estoque.Infrastructure.Context
{
    public class ProdutoContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           


        }
        public DbSet<Produto> Produtos { get; set; }
    }

}
