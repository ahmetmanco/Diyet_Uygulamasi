using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Mapping
{
    internal class KullaniciMapping : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.ToTable("Kullanicilar");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Ad)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(x => x.Soyad)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.HasIndex(x => x.Eposta)
                   .IsUnique();

            builder.Property(x => x.Telefon)
                   .IsRequired()
                   .HasMaxLength(10);

            builder.Property(x => x.Sifre)
                   .IsRequired()
                   .HasMaxLength(256);
        }
    }
}
