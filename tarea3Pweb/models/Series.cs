using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tarea3Pweb.models
{
    public class Series
    {
        public int Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        public string? Pais { get; set; }
        public string? Idioma { get; set; }
        public string? FotoUrl { get; set; }

        [Required]
        public string? Resumen { get; set; }

        // Relación uno a muchos con Personaje
        public List<Personaje> Personajes { get; set; } = new List<Personaje>();
    }
}