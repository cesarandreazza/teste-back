using System.ComponentModel.DataAnnotations;

namespace Aplicacao.Modelos;

public class PedidoModeloAtualizar
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string NomeCliente { get; set; } = null!;
    [Required]
    public string EmailCliente { get; set; } = null!;
    [Required]
    public bool Pago { get; set; }
    [Required]
    public ICollection<ItemPedidoModeloAtualizar> ItensPedido { get; set; } = null!;
}
