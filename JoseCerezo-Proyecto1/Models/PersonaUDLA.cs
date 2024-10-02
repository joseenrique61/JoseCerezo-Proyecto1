using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace JoseCerezo_Proyecto1.Models
{
    public class PersonaUDLA
    {
        [AllowNull]
        [Required]
        public string IdBanner { get; set; }

        [MaxLength(50)]
        public string? Nombre { get; set; }

        public string? Correo { get; set; }

        public Carrera Carrera { get; set; }
    }
}
