using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PracticaWeb.Data.Modelos
{
    public partial class PracticaEFContext : DbContext
    {
        public PracticaEFContext()
        {
        }

        public PracticaEFContext(DbContextOptions<PracticaEFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<TipoAnimal> TipoAnimals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-7MNH57O\\SQLEXPRESS; Database=Practica-EF;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Animal>(entity =>
            {
                entity.HasKey(e => e.IdAnimal);

                entity.ToTable("Animal");

                entity.Property(e => e.NombreEspecie)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.IdTipoAnimalNavigation)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.IdTipoAnimal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Animal_TipoAnimal");
            });

            modelBuilder.Entity<TipoAnimal>(entity =>
            {
                entity.HasKey(e => e.IdTipoAnimal);

                entity.ToTable("TipoAnimal");

                entity.Property(e => e.IdTipoAnimal).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
