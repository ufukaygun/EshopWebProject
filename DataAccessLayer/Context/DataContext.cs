using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    public class DataContext : DbContext
	{
		public DataContext(DbContextOptions options) : base(options) 
		{
		
		}
		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.UseSqlServer("Server=DESKTOP-URRDALT;Database=EShopWebProject;User Id=sa;Password=1234;TrustServerCertificate=true");
		//}
		public DbSet<Cart> Carts { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Sales> Sales { get; set; }
		public DbSet<User> Users { get; set; }
	}
}
