using System.ComponentModel.DataAnnotations.Schema;

namespace NLayerPractice.Core.Models
{
	public class ProductFeature
	{
		public int Id { get; set; }

		public string Color { get; set; }


		[ForeignKey("ProductId")]
		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
