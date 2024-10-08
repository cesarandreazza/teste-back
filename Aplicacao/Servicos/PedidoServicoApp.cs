using Aplicacao.DTO;
using Aplicacao.Interfaces;
using Aplicacao.Modelos;
using AutoMapper;
using Dominio.Entidades;
using Dominio.Interfaces.Servicos;

namespace Aplicacao.Servicos;

public class PedidoServicoApp : IPedidoServicoApp
{
    private readonly IPedidoServico _pedidoServico;
    private readonly IMapper _mapper;
    public PedidoServicoApp(IMapper mapper, IPedidoServico pedidoServico)
    {
        _pedidoServico = pedidoServico;
        _mapper = mapper;
    }

    public async Task AtualizarAsync(PedidoModeloAtualizar pedidoModeloAtualizar)
    {
        if (pedidoModeloAtualizar == null)
        {
            return;
        }
        var pedido = _mapper.Map<Pedido>(pedidoModeloAtualizar);
        await _pedidoServico.AtualizarAsync(pedido);
    }

    public async Task CriarAsync(PedidoModeloAtualizar pedidoModeloCriar)
    {
        if (pedidoModeloCriar == null)
        {
            return;
        }
        var pedido = _mapper.Map<Pedido>(pedidoModeloCriar);        
        await _pedidoServico.CriarAsync(pedido);
    }

    public async Task ExcluirAsync(int? id)
    {
        if (id.HasValue && id.Value > 0)
        {
            var pedido = await _pedidoServico.ObterAsync(id.Value);
            if (pedido != null)
            {
                await _pedidoServico.ExcluirAsync(pedido);
            }
        }        
    }

    public async Task<IEnumerable<PedidoModeloListar>> ListarAsync()
    {
        var pedidos = await _pedidoServico.ListarAsync();

        var pedidosModelo = _mapper.Map<IEnumerable<PedidoModeloListar>>(pedidos);

        return pedidosModelo;
    }

    public async Task<PedidoDto?> ObterAsync(int? id)
    {
        if (!id.HasValue)
        {
            return null;
        }
        var pedido = await _pedidoServico.ObterAsync(id.Value);
        if (pedido == null)
        {
            return null;
        }
        var pedidoDto = _mapper.Map<PedidoDto>(pedido);
        return pedidoDto;
    }
}
