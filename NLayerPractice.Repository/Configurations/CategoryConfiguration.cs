using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerPractice.Core.Models;

namespace NLayerPractice.Repository.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {// We don't use that so there is no problem for being internal.


        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id); //[Key]
            builder.Property(x => x.Id).UseIdentityColumn();//Increase one by one
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            //If we don't specifying table name, it use DbContext's name.
            builder.ToTable("Categories"); //Table Name
        }
    }
}
