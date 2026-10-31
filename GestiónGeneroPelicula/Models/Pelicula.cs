using System.ComponentModel.DataAnnotations;

namespace GestiónGeneroPelicula.Models
{
    public class Pelicula
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la película es obligatorio.")]
        [StringLength(150, ErrorMessage = "El nombre no puede superar los 150 caracteres.")]
        [Display(Name = "Nombre de la película")]
        public string Nombre { get; set; } = "";

        [Required(ErrorMessage = "El formato es obligatorio.")]
        [StringLength(50, ErrorMessage = "El formato no puede superar los 50 caracteres.")]
        [Display(Name = "Formato")]
        public string Formato { get; set; } = "";

        [Range(1, 500, ErrorMessage = "La duración debe estar entre 1 y 500 minutos.")]
        [Display(Name = "Duración (minutos)")]
        public int Duracion { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un género.")]
        [Display(Name = "Género")]
        public int GeneroId { get; set; }

        public Genero? Genero { get; set; }
    }
}
