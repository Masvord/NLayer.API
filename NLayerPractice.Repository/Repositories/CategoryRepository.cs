using Microsoft.EntityFrameworkCore;
using NLayerPractice.Core.Models;
using NLayerPractice.Core.Repositories;

namespace NLayerPractice.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(NLayerDbContext context) : base(context)
        {
        }

        //It returns category with spesific product.
        public async Task<Category> GetSingleCategoryByIdWithProductAsync(int categoryId)
        {
            return await _context.Categories
                .Include(x => x.Product)
                .Where(x => x.Id == categoryId)
                .SingleOrDefaultAsync();
        }
    }
}
