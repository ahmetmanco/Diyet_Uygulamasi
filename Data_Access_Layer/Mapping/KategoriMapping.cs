using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Mapping
{
    internal class KategoriMapping : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.ToTable("Kategoriler");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.KategoriAdi)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(x => x.Aciklama)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasMany(x => x.Yemekler)
                   .WithOne(y => y.Kategori)
                   .HasForeignKey(z => z.KategoriId);
        }
    }
}
