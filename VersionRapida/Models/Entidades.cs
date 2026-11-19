using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechFixPro.Models
{
    [Table("Tecnicos")]
    public class Tecnico
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string NombreCompleto { get; set; } = string.Empty;
        [Required, StringLength(50)]
        public string Especialidad { get; set; } = string.Empty;
        [Required, StringLength(20)]
        public string Telefono { get; set; } = string.Empty;
    }

    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(150)]
        public string Descripcion { get; set; } = string.Empty;
    }

    [Table("OrdenesServicio")]
    public class OrdenServicio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obligatorio"), StringLength(20, ErrorMessage = "Máx. 20 caracteres")]
        [Display(Name = "N° de Orden")]
        public string NumeroOrden { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obligatorio"), StringLength(100, MinimumLength = 3, ErrorMessage = "Entre 3 y 100 caracteres")]
        [Display(Name = "Nombre del Cliente")]
        public string NombreCliente { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obligatorio"), Phone(ErrorMessage = "Teléfono inválido"), StringLength(15)]
        [Display(Name = "Teléfono de Contacto")]
        public string TelefonoCliente { get; set; } = string.Empty;

        [Required(ErrorMessage = "Seleccione categoría"), Range(1, int.MaxValue)]
        [Display(Name = "Categoría de Dispositivo")]
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; }

        [Required(ErrorMessage = "Seleccione técnico"), Range(1, int.MaxValue)]
        [Display(Name = "Técnico Asignado")]
        public int TecnicoId { get; set; }
        [ForeignKey("TecnicoId")]
        public Tecnico? Tecnico { get; set; }

        [Required(ErrorMessage = "Obligatorio"), StringLength(250, ErrorMessage = "Máx. 250 caracteres")]
        [Display(Name = "Falla Reportada")]
        public string DescripcionFalla { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obligatorio"), Range(5000, 500000, ErrorMessage = "Entre $5.000 y $500.000")]
        [Display(Name = "Presupuesto Estimado ($)")]
        public double CostoEstimado { get; set; }

        [Required(ErrorMessage = "Obligatorio"), DataType(DataType.Date)]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime FechaIngreso { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Obligatorio")]
        public string Estado { get; set; } = "Pendiente";

        [Display(Name = "¿Aplica Garantía Técnica?")]
        public bool TieneGarantia { get; set; }
    }
}