using Microsoft.EntityFrameworkCore;
using NLayerPractice.Core.Models;
using NLayerPractice.Repository.Configurations;
using System.Reflection;

namespace NLayerPractice.Repository
{
    public class NLayerDbContext : DbContext
	{

		public NLayerDbContext(DbContextOptions<NLayerDbContext> options) : base(options)
		{
			//Constructor
		}


		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductFeature> ProductFeatures { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//This code makes it ease to use all configuration files.
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


			//Or we can use that options for add one by one.
			modelBuilder.ApplyConfiguration(new ProductConfiguration());


			base.OnModelCreating(modelBuilder);
		}

	}
}
