using Microsoft.AspNetCore.Mvc;
using NLayerPractice.API.Filters;
using NLayerPractice.Core.DTOs.CustomDTOs;

namespace NLayerPractice.API.Controllers
{
    [ValidateFilterAttribute]
    //I create this controller for returns.
    [Route("api/[controller]")]
    [ApiController]

    public class CustomBaseController : ControllerBase
    {
        [NonAction] // This is not endpoint.
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)
            {
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            }

            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}

