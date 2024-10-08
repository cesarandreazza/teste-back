using Aplicacao.DTO;
using Aplicacao.Modelos;

namespace Aplicacao.Interfaces;

public interface IPedidoServicoApp
{
    Task CriarAsync(PedidoModeloAtualizar pedidoModeloCriar);
    Task ExcluirAsync(int? id);
    Task AtualizarAsync(PedidoModeloAtualizar pedidoModeloAtualizar);
    Task<PedidoDto?> ObterAsync(int? id);
    Task<IEnumerable<PedidoModeloListar>> ListarAsync();
}
