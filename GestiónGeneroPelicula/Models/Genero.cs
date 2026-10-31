using System.ComponentModel.DataAnnotations;

namespace GestiónGeneroPelicula.Models
{
    public class Genero
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del género es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
        [Display(Name = "Nombre del género")]
        public string Nombre { get; set; } = "";

        [StringLength(200, ErrorMessage = "La descripción no puede superar los 200 caracteres.")]
        [Display(Name = "Descripción")]
        public string? Descripcion { get; set; }

        public ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
    }
}