using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;
using Dominio.Interfaces.Servicos;

namespace Dominio.Servicos;

public class ProdutoServico : Servico<Produto>, IProdutoServico
{
    protected readonly IProdutoRepositorio _produtoRepositorio;
    public ProdutoServico(IProdutoRepositorio repositorio) : base(repositorio)
    {
        _produtoRepositorio = repositorio;
    }
}
