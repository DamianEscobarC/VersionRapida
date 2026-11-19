using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VersionRapida.Models
{
    [Table("Tecnicos")]
    public class Tecnico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del técnico es obligatorio.")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string NombreCompleto { get; set; } = string.Empty;

        [Required(ErrorMessage = "La especialidad es obligatoria.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        public string Especialidad { get; set; } = string.Empty;

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        public string Telefono { get; set; } = string.Empty;
    }
}