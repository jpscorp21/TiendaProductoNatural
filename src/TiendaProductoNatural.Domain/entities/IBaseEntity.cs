namespace TiendaProductoNatural.Domain.entities;

public interface IBaseEntity 
{
    public int Id { get; set; }
    public bool Activo { get; set; }
    public string? Observacion { get; set; }
}