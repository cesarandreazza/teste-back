namespace Dominio.Entidades;

public class Pedido: EntidadeBase
{
    public string NomeCliente { get; set; } = null!;
    public string EmailCliente { get; set; } = null!;
    public DateTime DataCriacao { get; set; }
    public bool Pago { get; set; }
    public ICollection<ItensPedido> ItensPedidos { get; set; }
}
