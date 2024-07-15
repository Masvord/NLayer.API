using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerPractice.Core.Models;

namespace NLayerPractice.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            //We should to determine ID while seeding.
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Kurşun Kalem",
                Price = 60,
                Quantity = 20,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Uçlu Kalem",
                Price = 132,
                Quantity = 45,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Tükenmez Kalem",
                Price = 50,
                Quantity = 100,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 4,
                CategoryId = 2,
                Name = "Fahrenheit 451",
                Price = 50,
                Quantity = 100,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 5,
                CategoryId = 2,
                Name = "Dava",
                Price = 50,
                Quantity = 100,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 6,
                CategoryId = 2,
                Name = "Suç ve Ceza",
                Price = 78,
                Quantity = 23,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 7,
                CategoryId = 3,
                Name = "Defter",
                Price = 50,
                Quantity = 45,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 8,
                CategoryId = 3,
                Name = "Kareli Defter",
                Price = 78,
                Quantity = 23,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 9,
                CategoryId = 3,
                Name = "Çizgisiz Defter",
                Price = 26,
                Quantity = 230,
                CreatedDate = DateTime.Now,
            }
            );
        }
    }
}
