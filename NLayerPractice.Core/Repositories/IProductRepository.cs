using NLayerPractice.Core.Models;

namespace NLayerPractice.Core.Repositories
{
	public interface IProductRepository : IGenericRepository<Product>
	{
		Task<List<Product>> GetProductsWithCategory();
	}
}
