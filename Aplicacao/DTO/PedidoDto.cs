namespace Aplicacao.DTO;

public class PedidoDto
{
    public int Id { get; set; }
    public string NomeCliente { get; set; } = null!;
    public string EmailCliente { get; set; } = null!;
    public DateTime DataCriacao { get; set;}
    public bool Pago { get; set; }
    public ICollection<ItemPedidoDto> itensPedidoDtos { get; set; }
}
