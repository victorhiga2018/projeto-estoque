using AutoMapper;
using projeto_estoque.Application.Entitys.Commands;
using projeto_estoque.Application.Entitys.Models;

namespace projeto_estoque.Application.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CadastroProdutoCommand, Produto>().ReverseMap();
        }
    }
}
