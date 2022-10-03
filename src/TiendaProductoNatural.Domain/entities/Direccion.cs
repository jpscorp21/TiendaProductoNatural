namespace TiendaProductoNatural.Domain.entities;

public class Direccion : IBaseEntity
{
    public int Id { get; set; }
    public string? Pais { get; set; }
    public string? Ciudad { get; set; }
    public string? Departamento { get; set; }
    public string? Direccion1 { get; set; }
    public string? Direccion2 { get; set; }
    public bool Activo { get; set; }
    public string? Observacion { get; set; }
}