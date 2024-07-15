using System.ComponentModel.DataAnnotations.Schema;

namespace NLayerPractice.Core.DTOs
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }


        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
    }
}
