namespace TiendaProductoNatural.Domain.entities;

public class Persona : IBaseEntity
{
    public int Id { get; set; }
    public string Denominacion { get; set; } = string.Empty;
    public string? Telefono { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Correo { get; set; } = string.Empty;
    public bool EsProveedor { get; set; }
    public bool Activo { get; set; }
    public string? Observacion { get; set; }
}