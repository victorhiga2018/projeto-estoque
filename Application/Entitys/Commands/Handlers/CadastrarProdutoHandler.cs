using AutoMapper;
using MediatR;
using projeto_estoque.Application.Entitys.Models;
using projeto_estoque.Application.Entitys.Commands.Requests;
using projeto_estoque.Application.Entitys.Commands.Responses;
using projeto_estoque.Repositories;

namespace projeto_estoque.Application.Entitys.Commands.Handlers
{
    public class CadastrarProdutoHandler : IRequestHandler<ProdutoCadastroRequest, ProdutoCadastroResponse>
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;
        public CadastrarProdutoHandler(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }
        public Task<ProdutoCadastroResponse> Handle(ProdutoCadastroRequest request, CancellationToken cancellationToken)
        {
            Produto cadastro = _mapper.Map<Produto>(request);

            _produtoRepository.Cadastrar(cadastro);

            return Task.FromResult(new ProdutoCadastroResponse { Sucesso = true, Mensagem = "CADASTRADO COM SUCESSO!" });   
        }
    }
}
