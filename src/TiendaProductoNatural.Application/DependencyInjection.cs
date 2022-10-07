using Microsoft.Extensions.DependencyInjection;
using TiendaProductoNatural.Application.Services;


namespace TiendaProductoNatural.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ProductoService>();
        services.AddScoped<PersonaService>();
        services.AddScoped<ProductoCategoriaService>();
        return services;
    }
}