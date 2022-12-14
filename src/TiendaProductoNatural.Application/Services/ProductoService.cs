using TiendaProductoNatural.Application.Models;
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
    
    public Producto Create(ProductoCategoriaDto body)
    {
        if (body == null)
        {
            throw new ArgumentNullException(nameof(body));
        }
        
        return new Producto();
    }
    
    public Producto Update(ProductoCategoriaDto body, int id)
    {
        if (body == null)
        {
            throw new ArgumentNullException(nameof(body));
        }
        
        return new Producto();
    }
    
    public Producto Remove(int id)
    {
        return new Producto();
    }
}