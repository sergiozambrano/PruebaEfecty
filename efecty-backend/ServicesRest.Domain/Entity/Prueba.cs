namespace ServicesRest.Domain.Entity;

public partial class Prueba
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? TipoDocumento { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public decimal? ValorGanar { get; set; }

    public string? EstadoCivil { get; set; }
}
