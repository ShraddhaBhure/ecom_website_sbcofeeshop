
using cofee.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace cofee.data
{
	public class CoffeeDbContext : IdentityDbContext
    {
		
		public CoffeeDbContext(DbContextOptions<CoffeeDbContext> options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Configure the Product entity
			modelBuilder.Entity<Product>().HasData(
				 new Product
				 {
					 Id = 1,
					 Name = "Flat White",
					 Detail = "A coffee drink consisting of espresso with microfoam (steamed milk with fine, velvety bubbles).",
					 ImageUrl = "/images/cofeeimages/flat-white.jpg",
					 Price = 4.99m,
					 IsTrendingProduct = true
				 },
				 new Product
				 {
					 Id = 2,
					 Name = "Mocha",
					 Detail = "Espresso mixed with hot chocolate and steamed milk, topped with whipped cream.",
					 ImageUrl = "/images/cofeeimages/mocha.jpg", // Update the image path
					 Price = 5.49m,
					 IsTrendingProduct = false
				 },
			new Product
			{
				Id = 3,
				Name = "Affogato",
				Detail = "A dessert coffee made by pouring a shot of hot espresso over a scoop of vanilla ice cream.",
				ImageUrl = "/images/cofeeimages/affogato.jpg", // Update the image path
				Price = 6.99m,
				IsTrendingProduct = true
			},
			new Product
			{
				Id = 4,
				Name = "Turkish Coffee",
				Detail = "A traditional method of preparing unfiltered coffee with finely ground coffee beans and spices.",
				ImageUrl = "/images/cofeeimages/turkish-coffee.jpg", // Update the image path
				Price = 7.99m,
				IsTrendingProduct = false
			},
			new Product
			{
				Id = 5,
				Name = "Iced Coffee",
				Detail = "Chilled coffee served over ice, often sweetened and with the option of milk or cream.",
				ImageUrl = "/images/cofeeimages/iced-coffee.jpg", // Update the image path
				Price = 3.99m,
				IsTrendingProduct = true
			}
				);
			

			base.OnModelCreating(modelBuilder);
		}


	}
}
