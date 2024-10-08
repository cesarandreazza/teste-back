namespace Aplicacao.Modelos;

public class ItemPedidoModeloListar
{
    public int Id { get; set; }
    public int IdProduto { get; set; }
    public string NomeProduto { get; set; } = null!;
    public decimal ValorUnitario { get; set; }
    public int Quantidade { get; set; }
}
