using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerPractice.Core.Models;

namespace NLayerPractice.Repository.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey("Id");
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Quantity).IsRequired();

            builder.ToTable("Products");

            builder.HasOne(x => x.Category).
                WithMany(x => x.Product).//This and above line define table relationship but there is no need. Because we defined relationship in layer Core.
                HasForeignKey(x => x.CategoryId);
        }
    }
}
