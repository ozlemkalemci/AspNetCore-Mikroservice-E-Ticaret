using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities;

public class Product
{
	[BsonId]
	[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
	public string ProductId { get; set; }
	public string ProductName { get; set; }
	public decimal Price { get; set; }
	public decimal ProductImageUrl { get; set; }
	public string ProductDescription { get; set; }
	public string CategoryId { get; set; }
	[BsonIgnore]
	public Category Category { get; set; }
}