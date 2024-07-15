using AutoMapper;
using NLayerPractice.Core.DTOs;
using NLayerPractice.Core.DTOs.CustomDTOs;
using NLayerPractice.Core.Models;
using NLayerPractice.Core.Repositories;
using NLayerPractice.Core.Services;
using NLayerPractice.Core.UnitOfWorks;

namespace NLayerPractice.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IGenericRepository<Category> repository, ICategoryRepository categoryRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<CustomResponseDto<ProductWithCategoryDto>> GetSingleCategoryByIdWithProductAsync(int categoryId)
        {
            var category = await _categoryRepository.GetSingleCategoryByIdWithProductAsync(categoryId);

            var categoryDto = _mapper.Map<ProductWithCategoryDto>(category);

            return CustomResponseDto<ProductWithCategoryDto>.Success(200, categoryDto);

        }
    }
}
