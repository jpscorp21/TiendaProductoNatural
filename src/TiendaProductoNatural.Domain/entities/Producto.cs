namespace TiendaProductoNatural.Domain.entities;

public class Producto : IBaseEntity
{
    public int Id { get; set; }
    public string Codigo { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public double Descuento { get; set; }
    public decimal PrecioEspecial { get; set; }
    public decimal Precio { get; set; }
    public decimal Costo { get; set; }
    public int Stock { get; set; }
    public int StockMinimo { get; set; }
    public int PersonaId { get; set; }
    public Persona? Persona { get; set; }
    public int ProductoCategoriaId { get; set; }
    public ProductoCategoria? Categoria { get; set; }
    public bool Activo { get; set; }
    public string? Observacion { get; set; }
}