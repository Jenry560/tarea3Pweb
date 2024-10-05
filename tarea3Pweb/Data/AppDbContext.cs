
using Microsoft.EntityFrameworkCore;
using tarea3Pweb.models;

namespace tarea3Pweb.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Series> Series { get; set; }
        public DbSet<Personaje> Personajes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Series>().ToTable("Series");
            modelBuilder.Entity<Personaje>().ToTable("Personajes");

            // Configurar relación uno a muchos
            modelBuilder.Entity<Series>()
                .HasMany(s => s.Personajes)
                .WithOne(p => p.Series)
                .HasForeignKey(p => p.SerieId);
        }
    }
}