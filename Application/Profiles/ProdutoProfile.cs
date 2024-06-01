using AutoMapper;
using projeto_estoque.Application.Entitys.Commands.Requests;
using projeto_estoque.Application.Entitys.Models;

namespace projeto_estoque.Application.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<ProdutoCadastroRequest, Produto>().ReverseMap();
        }
    }
}
