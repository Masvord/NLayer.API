using NLayerPractice.Core.DTOs;
using NLayerPractice.Core.DTOs.CustomDTOs;
using NLayerPractice.Core.Models;

namespace NLayerPractice.Core.Services
{
	public interface IProductService : IService<Product>
	{
		Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();
	}
}
