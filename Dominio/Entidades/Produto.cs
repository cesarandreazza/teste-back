namespace Dominio.Entidades;

public class Produto : EntidadeBase
{
    public string Nome { get; set; } = null!;
    public decimal Valor { get; set; }

    public ICollection<ItensPedido> ItensPedidos { get; set; }
}
