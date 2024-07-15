using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerPractice.Core.Models;

namespace NLayerPractice.Repository.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(new ProductFeature
            {
                Id = 1,
                Color = "Red",
                ProductId = 1
            },

            new ProductFeature
            {
                Id = 2,
                Color = "Blue",
                ProductId = 2
            });
        }
    }
}
