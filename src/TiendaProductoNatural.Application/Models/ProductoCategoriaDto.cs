namespace TiendaProductoNatural.Application.Models;

public class ProductoCategoriaDto
{
    public int? Id { get; set; }
    public string? Codigo { get; set; }
    public string Descripcion { get; set; } = string.Empty;
    public bool? Activo { get; set; }
    public string? Observacion { get; set; }
}