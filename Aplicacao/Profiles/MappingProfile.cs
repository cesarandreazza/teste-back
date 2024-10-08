using Aplicacao.DTO;
using Aplicacao.Modelos;
using AutoMapper;
using Dominio.Entidades;

namespace Aplicacao.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Produto, ProdutoDto>();
        CreateMap<Pedido, PedidoDto>();
        CreateMap<ItensPedido, ItemPedidoDto>();
        CreateMap<ItemPedidoModeloCriar, ItensPedido>();
        CreateMap<ItemPedidoModeloAtualizar, ItensPedido>();
        CreateMap<PedidoModeloCriar, Pedido>()
            .ForMember(dest => dest.ItensPedidos, opt => opt.MapFrom(src => src.Itens));
        CreateMap<ItensPedido, ItemPedidoModeloListar>()
            .ForMember(dest => dest.NomeProduto, opt => opt.MapFrom(src => src.Produto.Nome))
            .ForMember(dest => dest.ValorUnitario, opt => opt.MapFrom(src => src.Produto.Valor));
        CreateMap<Pedido, PedidoModeloListar>()            
            .ForMember(dest => dest.ValorTotal, opt => opt.MapFrom(src => src.ItensPedidos.Sum(ip => ip.Produto.Valor * ip.Quantidade)))
            .ForMember(dest => dest.ItensPedido, opt => opt.MapFrom(src => src.ItensPedidos));
        CreateMap<PedidoModeloAtualizar, Pedido>()
            .ForMember(dest => dest.ItensPedidos, opt => opt.MapFrom(src => src.ItensPedido));
    }
}
