using DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
	public class ApplicationDbContext : IdentityDbContext<IdentityUser>
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //map models to physical tables
        public DbSet<Category> Categories { get; set; }  //the physical DB table will be name Categories
        public DbSet<Manufacturer> Manufacturers { get; set; }  //the physical DB table will be name Categories

        public DbSet<Product> Products { get; set; }  //the physical DB table will be name Categories

		public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<OrderHeader> OrderHeader { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }


        //insterting seed data when Model is physically created in the DB the first time
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //      {
        //          modelBuilder.Entity<Category>().HasData(
        //              new Category { CategoryId = 1, CategoryName = "Non-Alcoholic Beverages", DisplayOrder = 1 },
        //              new Category { CategoryId = 2, CategoryName = "Wine", DisplayOrder = 2 },
        //              new Category { CategoryId = 3, CategoryName = "Snacks", DisplayOrder = 3 }
        //             );

        //          modelBuilder.Entity<Manufacturer>().HasData(
        //              new Manufacturer { ManufacturerId = 1, ManufacturerName = "Coca Cola" },
        //              new Manufacturer { ManufacturerId = 2, ManufacturerName = "Yellow Tail" },
        //		new Manufacturer { ManufacturerId = 3, ManufacturerName = "Trinchero Family Estates" },
        //              new Manufacturer { ManufacturerId = 4, ManufacturerName = "Frito Lay" },
        //		new Manufacturer { ManufacturerId = 77, ManufacturerName = "Sweden" }
        //	   );


        //	modelBuilder.Entity<Product>().HasData(
        //			new Product
        //			{
        //				Id = 1,
        //				Name = "Coca Cola Classic",
        //				Description = "The primary taste of Coca-Cola is thought to come from vanilla and cinnamon, with trace amounts of essential oils, and spices such as nutmeg.",
        //				ListPrice = 1.99,
        //				UnitPrice = 1.49,
        //				HalfDozenPrice = 1.24,
        //				DozenPrice = .99,
        //				Size = "33cl",
        //				UPC = "4894034",
        //				ImageUrl = "/images/products/Coke.jpg",
        //				CategoryId = 1,
        //				ManufacturerId = 1
        //			},
        //		new Product
        //		{
        //			Id = 2,
        //			Name = "Yellow Tail Shiraz",
        //			Description = "<p>The Yellow Tail Shiraz has a deep red color with bright purple hues, characteristic of fine young wines. It displays impressive <strong>spice, licorice, and black currant aromas</strong>. The palate is perfectly balanced with soft tannins and fine French Oak, further complemented by ripe fruit flavors.</p>",
        //			ListPrice = 9.99,
        //			UnitPrice = 8.99,
        //			HalfDozenPrice = 7.99,
        //			DozenPrice = 6.99,
        //			Size = "750 ml",
        //			UPC = "031259008943",
        //			ImageUrl = "/images/products/YellowTail.png",
        //			CategoryId = 2,
        //			ManufacturerId = 2
        //		},
        //		new Product
        //		{
        //			Id = 3,
        //			Name = "Menage a Trois Merlot",
        //			Description = "Menage a Trois California Red Blend exposes the fresh, ripe, jam-like fruit that is the calling card of California wine. Forward, spicy and soft, this delicious dalliance makes the perfect accompaniment for grilled meats or chicken.",
        //			ListPrice = 12.99,
        //			UnitPrice = 11.49,
        //			HalfDozenPrice = 10.75,
        //			DozenPrice = 9.99,
        //			Size = "750 ml",
        //			UPC = "099988071096",
        //			ImageUrl = "/images/products/menage.jpg",
        //			CategoryId = 2,
        //			ManufacturerId = 3
        //		},
        //		new Product
        //		{
        //			Id = 4,
        //			Name = "Doritos",
        //			Description = "The chip that packs a flavorful punch with the classic crunch. Boldly seasoned with three cheeses, tomatoes, onions, and a savory blend of spices. Indulge yourself or share with large gatherings",
        //			ListPrice = 1.99,
        //			UnitPrice = 1.49,
        //			HalfDozenPrice = 1.05,
        //			DozenPrice = .69,
        //			Size = "175 grams",
        //			UPC = "028400443753",
        //			ImageUrl = "/images/products/doritos.jpg",
        //			CategoryId = 3,
        //			ManufacturerId = 4
        //		},
        //		new Product
        //		{
        //			Id = 5,
        //			Name = "Cheetos",
        //			Description = "The fun, crunchy snack that is made with real cheese. Packed with flavor that satisfies. Always a crowd favorite.",
        //			ListPrice = 1.99,
        //			UnitPrice = 1.49,
        //			HalfDozenPrice = 1.05,
        //			DozenPrice = .69,
        //			Size = "200 grams",
        //			UPC = "028400443661",
        //			ImageUrl = "/images/products/cheetos.jpg",
        //			CategoryId = 3,
        //			ManufacturerId = 4
        //		}
        //	);
        //}

    }
}
