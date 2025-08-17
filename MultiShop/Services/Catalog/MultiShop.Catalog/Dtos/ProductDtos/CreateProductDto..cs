namespace MultiShop.Catalog.Dtos.ProductDtos
{
	public class CreateProductDto
	{
		public string ProductName { get; set; }
		public decimal Price { get; set; }
		public decimal ProductImageUrl { get; set; }
		public string ProductDescription { get; set; }
		public string CategoryId { get; set; }
	}
}
