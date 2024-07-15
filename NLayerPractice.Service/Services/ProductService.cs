using AutoMapper;
using NLayerPractice.Core.DTOs;
using NLayerPractice.Core.DTOs.CustomDTOs;
using NLayerPractice.Core.Models;
using NLayerPractice.Core.Repositories;
using NLayerPractice.Core.Services;
using NLayerPractice.Core.UnitOfWorks;

namespace NLayerPractice.Service.Services
{
    //Products Operation
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;


        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IMapper mapper, IProductRepository productRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory()
        {
            var products = await _productRepository.GetProductsWithCategory();

            var productsDto = _mapper.Map<List<ProductWithCategoryDto>>(products);

            return CustomResponseDto<List<ProductWithCategoryDto>>.Success(200, productsDto);
        }
    }
}
