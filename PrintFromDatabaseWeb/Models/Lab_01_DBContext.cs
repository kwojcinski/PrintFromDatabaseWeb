using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrintFromDatabaseWeb.Models
{
    public partial class Lab_01_DBContext : DbContext
    {
        public Lab_01_DBContext()
        {
        }

        public Lab_01_DBContext(DbContextOptions<Lab_01_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Miasta> Miasta { get; set; }
        public virtual DbSet<Skocznie> Skocznie { get; set; }
        public virtual DbSet<Trenerzy> Trenerzy { get; set; }
        public virtual DbSet<Uczestnictwa> Uczestnictwa { get; set; }
        public virtual DbSet<Zawodnicy> Zawodnicy { get; set; }
        public virtual DbSet<Zawody> Zawody { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=laboratorium1.database.windows.net;Database=Lab_01_DB;User Id=uzytkownik;Password=haslo-123;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Miasta>(entity =>
            {
                entity.HasKey(e => e.IdMiasta)
                    .HasName("miasta_pk");

                entity.ToTable("miasta");

                entity.Property(e => e.IdMiasta)
                    .HasColumnName("id_miasta")
                    .ValueGeneratedNever();

                entity.Property(e => e.NazwaMiasta)
                    .IsRequired()
                    .HasColumnName("nazwa_miasta")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skocznie>(entity =>
            {
                entity.HasKey(e => e.IdSkoczni)
                    .HasName("skocznie_pk");

                entity.ToTable("skocznie");

                entity.Property(e => e.IdSkoczni)
                    .HasColumnName("id_skoczni")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdMiasta).HasColumnName("id_miasta");

                entity.Property(e => e.K).HasColumnName("k");

                entity.Property(e => e.KrajSkoczni)
                    .HasColumnName("kraj_skoczni")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NazwaSkoczni)
                    .HasColumnName("nazwa_skoczni")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sedz).HasColumnName("sedz");
            });

            modelBuilder.Entity<Trenerzy>(entity =>
            {
                entity.HasKey(e => e.IdTrenera)
                    .HasName("trenerzy_pk");

                entity.ToTable("trenerzy");

                entity.Property(e => e.IdTrenera)
                    .HasColumnName("id_trenera")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataUrT)
                    .HasColumnName("data_ur_t")
                    .HasColumnType("date");

                entity.Property(e => e.ImieT)
                    .IsRequired()
                    .HasColumnName("imie_t")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NazwiskoT)
                    .IsRequired()
                    .HasColumnName("nazwisko_t")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Uczestnictwa>(entity =>
            {
                entity.HasKey(e => e.IdUczestnictwa)
                    .HasName("uczestnictwa_pk");

                entity.ToTable("uczestnictwa");

                entity.Property(e => e.IdUczestnictwa)
                    .HasColumnName("id_uczestnictwa")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdZawodnika).HasColumnName("id_zawodnika");

                entity.Property(e => e.IdZawodow).HasColumnName("id_zawodow");
            });

            modelBuilder.Entity<Zawodnicy>(entity =>
            {
                entity.HasKey(e => e.IdZawodnika)
                    .HasName("zawodnicy_pk");

                entity.ToTable("zawodnicy");

                entity.Property(e => e.IdZawodnika)
                    .HasColumnName("id_zawodnika")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataUr)
                    .HasColumnName("data_ur")
                    .HasColumnType("date");

                entity.Property(e => e.IdTrenera).HasColumnName("id_trenera");

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasColumnName("imie")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kraj)
                    .IsRequired()
                    .HasColumnName("kraj")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasColumnName("nazwisko")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Waga)
                    .HasColumnName("waga")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Wzrost).HasColumnName("wzrost");
            });

            modelBuilder.Entity<Zawody>(entity =>
            {
                entity.HasKey(e => e.IdZawodow)
                    .HasName("zawody_pk");

                entity.ToTable("zawody");

                entity.Property(e => e.IdZawodow)
                    .HasColumnName("id_zawodow")
                    .ValueGeneratedNever();

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.IdSkoczni).HasColumnName("id_skoczni");

                entity.Property(e => e.Nazwa)
                    .HasColumnName("nazwa")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
