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
    
    public Persona Create()
    {
        return new Persona();
    }
}