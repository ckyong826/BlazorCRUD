using ProductSystem.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace ProductSystem.Shared.Data
{
	public class DataContext :DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}
		public DbSet<Product> Products { get; set; }
	}
}
