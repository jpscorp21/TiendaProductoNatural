using TiendaProductoNatural.Application.Models;
using TiendaProductoNatural.Domain.entities;
using TiendaProductoNatural.Infrastructure.Contexts;

namespace TiendaProductoNatural.Application.Services;

public class PersonaService
{
    private readonly ApplicationDbContext _context;

    public PersonaService(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    
    public IEnumerable<Persona> FindAll()
    {
        return new List<Persona>();
    }
    
    public Persona Create(PersonaCreateDto body)
    {
        if (body == null)
        {
            throw new ArgumentNullException(nameof(body));
        }
        
        return new Persona();
    }
    
    public Persona Update(PersonaCreateDto body, int id)
    {
        if (body == null)
        {
            throw new ArgumentNullException(nameof(body));
        }
        
        return new Persona();
    }
    
    public Persona Remove(int id)
    {
        return new Persona();
    }
}