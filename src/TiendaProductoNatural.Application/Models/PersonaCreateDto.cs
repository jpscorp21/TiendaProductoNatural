namespace TiendaProductoNatural.Application.Models;

public class PersonaCreateDto
{
    public int Id { get; set; }
    public string Denominacion { get; set; } = string.Empty;
    public string? Ruc { get; set; }
    public string? Telefono { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Correo { get; set; } = string.Empty;
    public bool EsProveedor { get; set; }
    public int? DireccionId { get; set; }
    public bool Activo { get; set; }
    public string? Observacion { get; set; }
}