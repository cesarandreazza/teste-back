using Aplicacao.DTO;
using Aplicacao.Modelos;

namespace Aplicacao.Interfaces;

public interface IPedidoServicoApp
{
    Task CriarAsync(PedidoModeloCriar pedidoModeloCriar);
    Task ExcluirAsync(int? id);
    Task AtualizarAsync(PedidoModeloAtualizar pedidoModeloAtualizar);
    Task<PedidoModeloListar?> ObterAsync(int? id);
    Task<IEnumerable<PedidoModeloListar>> ListarAsync();
}
