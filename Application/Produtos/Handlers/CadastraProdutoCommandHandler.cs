using AutoMapper;
using MediatR;
using projeto_estoque.Application.Entitys.Models;
using projeto_estoque.Repositories;
using projeto_estoque.Application.Entitys.Commands;
using projeto_estoque.Application.Entitys.Responses;

namespace projeto_estoque.Application.Entitys.Handlers
{
    public class CadastraProdutoCommandHandler : IRequestHandler<CadastroProdutoCommand, CadastroProdutoResponse>
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;
        public CadastraProdutoCommandHandler(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }
        public Task<CadastroProdutoResponse> Handle(CadastroProdutoCommand request, CancellationToken cancellationToken)
        {
            Produto cadastro = _mapper.Map<Produto>(request);

            _produtoRepository.Cadastrar(cadastro);

            return Task.FromResult(new CadastroProdutoResponse { Sucesso = true, Mensagem = "CADASTRADO COM SUCESSO!" });
        }
    }
}
