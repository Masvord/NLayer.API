using NLayerPractice.Core.DTOs;
using NLayerPractice.Core.DTOs.CustomDTOs;

namespace NLayerPractice.Web.Services
{
    //Take category information
    public class CategoryApiService
    {
        private readonly HttpClient _httpClient;

        public CategoryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<List<CategoryDto>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CategoryDto>>>("categories");
            return response.Data;
        }
    }
}
