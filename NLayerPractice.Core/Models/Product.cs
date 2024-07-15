using System.ComponentModel.DataAnnotations.Schema;

namespace NLayerPractice.Core.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }


        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; }

    }
}
