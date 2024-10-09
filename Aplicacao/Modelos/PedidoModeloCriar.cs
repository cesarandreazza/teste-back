using System.ComponentModel.DataAnnotations;

namespace Aplicacao.Modelos;

public class PedidoModeloCriar
{
    [Required]
    public string NomeCliente { get; set; } = null!;
    [Required]
    public string EmailCliente { get; set; } = null!;
    [Required]
    public bool Pago { get; set; }
    [Required]
    public ICollection<ItemPedidoModeloCriar> ItensPedido { get; set; } = null!;
}
