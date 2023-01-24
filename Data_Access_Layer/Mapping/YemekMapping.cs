using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Mapping
{
    internal class YemekMapping : IEntityTypeConfiguration<Yemek>
    {
        public void Configure(EntityTypeBuilder<Yemek> builder)
        {
            builder.ToTable("Yemekler");
            builder.HasKey(x => x.YemekId);

            builder.Property(x => x.YemekAdi)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(x => x.Kalori)
                   .IsRequired()
                   .HasColumnType("decimal(5,2)");

            builder.Property(x => x.Fotograf);


            // One To Many
            builder.HasOne<Kategori>(x => x.Kategori)
                   .WithMany(y => y.Yemekler)
                   .HasForeignKey(x => x.KategoriId);
        }
    }
}
