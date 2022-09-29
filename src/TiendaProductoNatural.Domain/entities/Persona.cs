namespace TiendaProductoNatural.Domain.entities;

public class Persona : IBaseEntity
{
    public int Id { get; set; }
    public string? Observacion { get; set; }
}