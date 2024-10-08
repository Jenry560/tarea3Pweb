using System.ComponentModel.DataAnnotations;

namespace tarea3Pweb.models
{
    public class Personaje
    {
        public int Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        public string? Apodo { get; set; }
        public string? Raza { get; set; }
        public string? FotoUrl { get; set; }

        [Range(0, 150)]
        public int Edad { get; set; }

        public string? PoderCaracteristico { get; set; }

        // Relación con SeriePeliculaLibro
        [Required(ErrorMessage = "El campo serie es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El campo campo serie es obligatorio")]
        public int SerieId { get; set; }
        public Series Series { get; set; } = new Series();
    }
}