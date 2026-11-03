
using Microsoft.EntityFrameworkCore;
using PortfolioApi.Models;

namespace PortfolioApi.Data;

public sealed class PortfolioDbContext : DbContext
{
    public PortfolioDbContext(
        DbContextOptions<PortfolioDbContext> options) : base(options)
    {
    }

    public DbSet<Project> Projects => Set<Project>();

    public DbSet<Blogpost> Blogposts => Set<Blogpost>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(project => project.Id);

            entity.Property(project => project.Titel)
                .HasMaxLength(150)
                .IsRequired();

            entity.Property(project => project.Beschrijving)
                .HasMaxLength(4000)
                .IsRequired();

            entity.Property(project => project.Categorie)
                .HasMaxLength(100)
                .IsRequired();

            entity.Property(project => project.GitHubUrl)
                .HasMaxLength(2048)
                .IsRequired();

            entity.Property(project => project.Datum)
                .IsRequired();

            entity.Property(project => project.Status)
                .HasMaxLength(60)
                .IsRequired();

            entity.PrimitiveCollection(project => project.Technologieen)
                .HasColumnType("nvarchar(max)");

            entity.PrimitiveCollection(project => project.TechnischeDetails)
                .HasColumnType("nvarchar(max)");
        });

        modelBuilder.Entity<Blogpost>(entity =>
        {
            entity.HasKey(blogpost => blogpost.Id);

            entity.Property(blogpost => blogpost.Titel)
                .HasMaxLength(150)
                .IsRequired();

            entity.Property(blogpost => blogpost.Inhoud)
                .HasMaxLength(20000)
                .IsRequired();

            entity.Property(blogpost => blogpost.Publicatiedatum)
                .IsRequired();
        });
    }
}
