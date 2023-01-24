using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Mapping
{
    internal class OgunMapping : IEntityTypeConfiguration<Ogun>
    {
        public void Configure(EntityTypeBuilder<Ogun> builder)
        {
            builder.ToTable("Ogunler");
            builder.HasKey(x => x.OgunId);

            builder.HasOne(x => x.Kullanici)
                   .WithMany(y => y.Ogunler)
                   .HasForeignKey(y => y.KullaniciId);
                  
            builder.Property(x => x.Tarih)
                   .IsRequired()
                   .HasColumnType("date");

            builder.Property(x => x.OgunNo)
                   .IsRequired();

            builder.Property(x => x.OgunTipi)
                   .IsRequired();

        }
    }
}
