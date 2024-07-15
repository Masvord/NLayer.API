using Microsoft.EntityFrameworkCore;
using NLayerPractice.Core.Models;
using NLayerPractice.Core.Repositories;

namespace NLayerPractice.Repository.Repositories
{
	public class ProductRepository : GenericRepository<Product>, IProductRepository
	{
		public ProductRepository(NLayerDbContext context) : base(context)
		{
		}

		public async Task<List<Product>> GetProductsWithCategory()
		{
			//Eager Loading :
			//It is a technique that allows preloading of related data when retrieving data from the database.
			return await _context.Products.Include(x => x.Category).ToListAsync();
		}
	}
}
