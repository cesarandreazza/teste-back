using Aplicacao.DTO;
using Aplicacao.Interfaces;
using AutoMapper;
using Dominio.Interfaces.Servicos;

namespace Aplicacao.Servicos;

public class ProdutoServicoApp : IProdutoServicoApp
{
    private readonly IProdutoServico _produtoServico;
    private readonly IMapper _mapper;
    public ProdutoServicoApp(IMapper mapper, IProdutoServico produtoServico)
    {
        _produtoServico = produtoServico;
        _mapper = mapper;
    }
    public async Task<IEnumerable<ProdutoDto>> ListarAsync()
    {
        var produtos = await _produtoServico.ListarAsync();

        var produtosDto = _mapper.Map<IEnumerable<ProdutoDto>>(produtos);

        return produtosDto;
    }
}
