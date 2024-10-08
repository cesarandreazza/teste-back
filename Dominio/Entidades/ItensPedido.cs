namespace Dominio.Entidades;

public class ItensPedido
{
    public int Id { get; set; }
    public int IdPedido { get; set; }
    public Pedido Pedido { get; set; } = null!;

    public int IdProduto { get; set; }
    public Produto Produto { get; set; } = null!;
    
    public int Quantidade { get; set; }
}
