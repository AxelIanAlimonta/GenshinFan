using Microsoft.EntityFrameworkCore;

namespace GenshinFan.Data;

public class GenshinImpactContext : DbContext
{
    public GenshinImpactContext(DbContextOptions<GenshinImpactContext> options)
        : base(options)
    {
    }

    public DbSet<Elemento> Elementos { get; set; }
    public DbSet<Region> Regiones { get; set; }
    public DbSet<TipoDeArma> TiposDeArma { get; set; }
    public DbSet<Personaje> Personajes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Elemento>().ToTable("Elemento");
        modelBuilder.Entity<Region>().ToTable("Region");
        modelBuilder.Entity<TipoDeArma>().ToTable("TipoDeArma");
        modelBuilder.Entity<Personaje>().ToTable("Personaje");


        // Configurar la relaci�n uno a muchos entre Personaje y Elemento
        modelBuilder.Entity<Personaje>()
            .HasOne(p => p.Elemento)
            .WithMany(e => e.Personajes)
            .HasForeignKey(p => p.Id_Elemento);

        // Configurar la relaci�n uno a muchos entre Personaje y Region
        modelBuilder.Entity<Personaje>()
            .HasOne(p => p.Region)
            .WithMany(r => r.Personajes)
            .HasForeignKey(p => p.Id_Region);

        // Configurar la relaci�n uno a muchos entre Personaje y TipoDeArma
        modelBuilder.Entity<Personaje>()
            .HasOne(p => p.TipoDeArma)
            .WithMany(t => t.Personajes)
            .HasForeignKey(p => p.Id_TipoDeArma);
    }
}