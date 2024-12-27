using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OgrenciBilgilendirmeApp.Model;

namespace OgrenciBilgilendirmeApp.Context
{
    internal class ObsDbContext : DbContext
    {

        public DbSet<Ogrenciler>? Ogrencilers { get; set; }
        public DbSet<Siniflar>? Siniflars { get; set; }
        public DbSet<OgrenciDersler>? OgrenciDerslers { get; set; }
        public DbSet<Dersler>? Derslers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=OMERTRYK;Initial Catalog=ObsBilgilendirmeDb;Integrated Security=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OgrenciDersler>()
       .HasKey(od => new { od.OgrenciId, od.DersId }); //CompositKey

            // OgrenciDersler -> Dersler İlişkisi
            modelBuilder.Entity<OgrenciDersler>()
                .HasOne(od => od.Dersler) // OgrenciDersler.Dersler
                .WithMany(d => d.derslers) // Dersler.derslers
                .HasForeignKey(od => od.DersId); // Foreign Key: DersId

            // OgrenciDersler -> Ogrenciler İlişkisi
            modelBuilder.Entity<OgrenciDersler>()
                .HasOne(od => od.Ogrenciler) // OgrenciDersler.Ogrenciler
                .WithMany(o => o.ogrenciDerslers) // Ogrenciler.ogrenciDerslers
                .HasForeignKey(od => od.OgrenciId); // Foreign Key: OgrenciId

            // Ogrenciler -> Siniflar İlişkisi
            modelBuilder.Entity<Ogrenciler>()
                .HasOne(o => o.Siniflar) // Ogrenciler.Siniflar
                .WithMany(s => s.ogrencilers) // Siniflar.ogrencilers
                .HasForeignKey(o => o.SinifId); // Foreign Key: SinifId
        }
    }
}
