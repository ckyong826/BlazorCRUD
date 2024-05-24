namespace ProductSystem.Shared.Entity
{
	public class Product
	{
		public int Id { get; set; }
		public required string UserName { get; set; }
		public DateTime DateCaptured { get; set; }
		public required string ProductModel { get; set; }
		public required string ProductPartNumber { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }

	}
}
