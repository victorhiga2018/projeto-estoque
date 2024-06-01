using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projeto_estoque.Models;

namespace projeto_estoque.Infrastructure.Context
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Preco).IsRequired();
            builder.Property(x => x.Peso).IsRequired();
            builder.Property(x => x.Tamanho).IsRequired();
            builder.Property(x => x.Fabricante).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Origem).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Validade).IsRequired();
        }
    }
}
