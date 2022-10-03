using TiendaProductoNatural.Domain.entities;
using TiendaProductoNatural.Infrastructure.Contexts;

namespace TiendaProductoNatural.Application.Services;

public class ProductoService
{
    private readonly ApplicationDbContext _context;

    public ProductoService(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public IEnumerable<Producto> FindAll()
    {
        return new List<Producto>();
    }
    
    public Producto Create()
    {
        return new Producto();
    }
}