namespace TiendaProductoNatural.Domain.entities;

public class ProductoCategoria : IBaseEntity
{
    public int Id { get; set; }
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public bool Activo { get; set; }
    public string? Observacion { get; set; }
}