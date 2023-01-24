using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Mapping
{
    internal class YemekOgunMapping : IEntityTypeConfiguration<YemekOgun>
    {
        public void Configure(EntityTypeBuilder<YemekOgun> builder)
        {
            //builder.HasKey(yo => yo.YemekOgunId)
            //       .HasAnnotation("SqlServer:Identity", "1, 1");

            //builder.Property(yo => yo.YemekOgunId)
            //       .HasColumnOrder(0);

            // Many To Many
            builder.HasKey(yo => new { yo.YemekOgunId, yo.OgunId, yo.YemekId});

            builder.Property(yo => yo.YemekOgunId).ValueGeneratedOnAdd();

            builder.Property(yo => yo.Porsiyon)
                   .HasColumnType("decimal(5,2)");
        }
    }
}
