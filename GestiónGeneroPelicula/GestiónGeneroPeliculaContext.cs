using Microsoft.EntityFrameworkCore;

public class GestiónGeneroPeliculaContext(DbContextOptions<GestiónGeneroPeliculaContext> options) : DbContext(options)
{
    public DbSet<GestiónGeneroPelicula.Models.Pelicula> Pelicula { get; set; } = default!;
}
