using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;
using Dominio.Interfaces.Servicos;

namespace Dominio.Servicos;

public class PedidoServico : Servico<Pedido>, IPedidoServico
{
    protected readonly IPedidoRepositorio _pedidoRepositorio;
    public PedidoServico(IPedidoRepositorio repositorio) : base(repositorio)
    {
        _pedidoRepositorio = repositorio;
    }

    public override async Task CriarAsync(Pedido pedido)
    {
        if (pedido.ItensPedidos.Count == 0)
        {
            throw new InvalidOperationException("Pedido sem itens.");
        }

        pedido.DataCriacao = DateTime.Now;
        await _pedidoRepositorio.CriarAsync(pedido);
    }
}
