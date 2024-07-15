using System.ComponentModel.DataAnnotations.Schema;

namespace NLayerPractice.Core.DTOs
{
	public class ProductFeatureDto
	{
		public int Id { get; set; }

		public string Color { get; set; }


		[ForeignKey("ProductId")]
		public int ProductId { get; set; }
	}
}
