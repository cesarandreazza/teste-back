using System.ComponentModel.DataAnnotations;

namespace Aplicacao.Modelos;

public class PedidoModeloCriar
{
    [Required]
    public string NomeCliente { get; set; } = null!;
    [Required]
    public string EmailCliente { get; set; } = null!;
    public ICollection<ItemPedidoModeloCriar> Itens { get; set; } = null!;
}
