using Microsoft.EntityFrameworkCore;
using ServicesRest.Domain.Entity;

namespace ServicesRest.Infrastructure.DataAccess;

public partial class EfectyContext : DbContext
{
    public EfectyContext()
    {
    }

    public EfectyContext(DbContextOptions<EfectyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Prueba> Pruebas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Prueba>(entity =>
        {
            entity.ToTable("prueba");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(50)
                .HasColumnName("estado_civil");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .HasColumnName("tipo_documento");
            entity.Property(e => e.ValorGanar)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("valor_ganar");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
