namespace TiendaProductoNatural.Domain.entities;

public class Producto : IBaseEntity
{
    public int Id { get; set; }
    public string? Observacion { get; set; }
}