using Aplicacao.DTO;

namespace Aplicacao.Interfaces;

public interface IProdutoServicoApp
{
    Task<IEnumerable<ProdutoDto>> ListarAsync();
}
