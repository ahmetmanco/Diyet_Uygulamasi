using Data_Access_Layer.Mapping;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Data_Access_Layer.Context
{
    public class DiyetUygulamasiContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<YemekOgun> YemekOgun { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.; Database=DiyetUygulamasi; Trusted_Connection=true; encrypt=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KullaniciMapping());
            modelBuilder.ApplyConfiguration(new YemekMapping());
            modelBuilder.ApplyConfiguration(new KategoriMapping());
            modelBuilder.ApplyConfiguration(new OgunMapping());
            modelBuilder.ApplyConfiguration(new YemekOgunMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}
