using NLayerPractice.Core.DTOs;
using NLayerPractice.Core.DTOs.CustomDTOs;
using NLayerPractice.Core.Models;

namespace NLayerPractice.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDto<ProductWithCategoryDto>> GetSingleCategoryByIdWithProductAsync(int categoryId);
    }
}
