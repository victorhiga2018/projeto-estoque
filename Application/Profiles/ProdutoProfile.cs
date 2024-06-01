using AutoMapper;
using projeto_estoque.Application.Entitys.Commands;
using projeto_estoque.Application.Entitys.Models;
using projeto_estoque.Application.Produtos.Commands;
using projeto_estoque.Application.Produtos.Queries;

namespace projeto_estoque.Application.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CadastroProdutoCommand, Produto>().ReverseMap();
            CreateMap<ConsultaProdutoPorIdQuery, Produto>().ReverseMap();
        }
    }
}
