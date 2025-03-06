namespace ServicesRest.Application.Dto
{
    public class PruebaDto
    {
        public string Name { get; set; } = null!;

        public string? TipoDocumento { get; set; }

        public DateOnly? FechaNacimiento { get; set; }

        public decimal? ValorGanar { get; set; }

        public string? EstadoCivil { get; set; }
    }
}
