using System.ComponentModel.DataAnnotations;

namespace Aplicacao.Modelos;

public class ItemPedidoModeloAtualizar
{
    public int? Id { get; set; }
    [Required]
    public int IdProduto { get; set; }
    [Required]
    public int Quantidade { get; set;}
}
