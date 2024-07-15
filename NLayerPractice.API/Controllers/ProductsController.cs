using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayerPractice.Core.DTOs;
using NLayerPractice.Core.DTOs.CustomDTOs;
using NLayerPractice.Core.Models;
using NLayerPractice.Core.Services;

namespace NLayerPractice.API.Controllers
{
    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;

        private readonly IProductService _service;

        public ProductsController(IMapper mapper, IService<Product> service, IProductService productService)
        {
            _mapper = mapper;
            _service = productService;
        }


        // https://localhost:????/api/products/GetProductsWithCategory
        [HttpGet("[action]")] //I prevented multiple answer conflicts 
        public async Task<IActionResult> GetProductsWithCategory()
        {
            return CreateActionResult(await _service.GetProductsWithCategory());
        }


        // https://localhost:????/api/products
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _service.GetAllAsync();

            var productsDtos = _mapper.Map<List<ProductDto>>(products.ToList());

            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));
        }

        [HttpGet("[action]/{categoryId}")]
        public IActionResult GetProductsByCategoryId(int categoryId)
        {
            var products = _service.Where(x => x.CategoryId == categoryId).ToList();

            var productsDto = _mapper.Map<List<ProductDto>>(products.ToList());

            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
        }
    }
}
