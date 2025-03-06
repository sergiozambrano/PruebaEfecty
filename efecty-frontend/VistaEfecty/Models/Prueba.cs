using System.ComponentModel.DataAnnotations;

namespace VistaEfecty.Models
{
    public class Prueba
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Name { get; set; } = null!;

        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string? TipoDocumento { get; set; }

        [DataType(DataType.Date)]
        public DateOnly? FechaNacimiento { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Solo se permiten números y hasta 2 decimales")]
        public decimal? ValorGanar { get; set; }

        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string? EstadoCivil { get; set; }
    }
}
