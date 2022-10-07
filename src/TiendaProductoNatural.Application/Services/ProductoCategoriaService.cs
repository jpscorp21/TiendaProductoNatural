using TiendaProductoNatural.Application.Models;
using TiendaProductoNatural.Domain.entities;
using TiendaProductoNatural.Infrastructure.Contexts;

namespace TiendaProductoNatural.Application.Services;

public class ProductoCategoriaService
{
    private readonly ApplicationDbContext _context;

    public ProductoCategoriaService(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    
    public IEnumerable<ProductoCategoria> FindAll()
    {
        return new List<ProductoCategoria>();
    }
    
    public ProductoCategoria Create(ProductoCategoriaDto body)
    {
        if (body == null)
        {
            throw new ArgumentNullException(nameof(body));
        }
        
        return new ProductoCategoria();
    }
    
    public ProductoCategoria Update(ProductoCategoriaDto body, int id)
    {
        if (body == null)
        {
            throw new ArgumentNullException(nameof(body));
        }
        
        return new ProductoCategoria();
    }
    
    public ProductoCategoria Remove(int id)
    {
        return new ProductoCategoria();
    }
}