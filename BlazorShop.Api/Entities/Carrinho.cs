using System.Collections.ObjectModel;

namespace BlazorShop.Api.Entities;

public class Carrinho
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public Collection<CarrinhoItem> Itens { get; set; }
        = new Collection<CarrinhoItem>();
}

