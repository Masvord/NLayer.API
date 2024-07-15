using NLayerPractice.Core.Models;

namespace NLayerPractice.Core.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {

        Task<Category> GetSingleCategoryByIdWithProductAsync(int categoryId);




    }
}
