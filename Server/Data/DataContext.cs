using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            //  Creating composite primary key for Product variant. 
            modelBuilder.Entity<ProductVariant>().HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
                new Category { Id = 2, Name = "Outdoor", Url = "outoor", Icon = "image" },
                new Category { Id = 3, Name = "Dogs", Url = "dogs", Icon = "map-marker" }
            );

            modelBuilder.Entity<Product>().HasData(
                  new Product
                  {
                      Id = 1,
                      CategoryId = 1,
                      Title = "The C# Player's Guide (5th Edition)",
                      Description = "The book in your hands is a different kind of programming book. Like an entertaining video game, programming is an often challenging but always rewarding experience. This book shakes off the dusty, dull, dryness of the typical programming book, replacing it with something more exciting and flavorful: a bit of humor, a casual tone, and examples involving dragons and asteroids instead of bank accounts and employees.",
                      Image = "https://m.media-amazon.com/images/I/619vzxml9jL._SY466_.jpg",
                      DateCreated = new DateTime(2021, 1, 1)
                  },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "The Pragmatic Programmer",
                    Description = "The Pragmatic Programmer is one of those rare tech audiobooks you’ll listen, re-listen, and listen to again over the years. Whether you’re new to the field or an experienced practitioner, you’ll come away with fresh insights each and every time. ",
                    Image = "https://m.media-amazon.com/images/I/51A8l+FxFNL.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 2,
                    Title = "Sawyer Products SP128 Mini Water Filtration System, Single, Blue",
                    Description = "A lightweight, versatile personal filtration system, the second-generation Sawyer MINI Water Filter fits in the palm of your hand and has a total field weight of just 2 ounces. Perfect for everything from camping with the kids to traveling abroad where tap and bottle water can't be trusted, the tiny MINI provides 0.1 micron absolute filtration for clean drinking water on the go — filtering out bacteria, protozoa, and microplastics. ",
                    Image = "https://m.media-amazon.com/images/I/71Tx3ivOTYL._SX522_.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Black Diamond Alpine Carbon Cork Trekking Poles",
                    Description = "Our 100% carbon fiber trekking pole built to withstand four-season alpine terrain now features our newly redesigned FlickLock Pro adjustable technology, which is lighter, more ergonomic and easier to use.",
                    Image = "https://m.media-amazon.com/images/I/51pMA8KiXJL._AC_SY879_.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Osprey Daylite Plus Commuter Backpack",
                    Description = "Since Osprey was founded in 1974, every single product design has passed through the hands of owner and founder Mike Pfotenhauer, who created his first backpack at age 16. In Santa Cruz, California, the young entrepreneur opened a retail shop in the front of his rental house where backpackers and travelers came for custom-fit, made-to-order packs constructed over several days by Mike himself. As the demand for the great-fitting packs increased, Osprey found itself relocating to its current home in Southwest Colorado. Today, Osprey is a melting pot of diverse personalities, backgrounds and abilities. All share the common belief that adventure is open to everyone and found anywhere.",
                    Image = "https://m.media-amazon.com/images/I/81VSFgVff1L._AC_SX466_.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 3,
                    Title = "Carhartt Firm Duck Insulated Dog Chore Coat Brown/Brass",
                    Description = "12-Ounce firm-hand 100% ring spun cotton Duck dog vest with water-repellent coating quilted nylon lining for warmth and easy on and off corduroy-trimmed collar tucks into coat two rivet-reinforced pockets Carhartt label sewn on pocketfully-adjustable hook-and loop neck and chest tabs size Small 13 - 17  Neck 16 - 21 Chest",
                    Image = "https://m.media-amazon.com/images/I/717qKZOTbhS._AC_SL1500_.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "KONG 41938 Classic Dog Toy",
                    Description = "The KONG Classic is the gold standard of dog toys. Offering enrichment by helping satisfy dogs’ instinctual needs, the KONG Classic’s unique natural red rubber formula is ultra-durable with an erratic bounce that is ideal for dogs that like to chew while also fulfilling a dog’s need to play. Great for stuffing with KONG Easy Treat; Snacks or Ziggies. Made in the USA. Globally Sourced Materials.",
                    Image = "https://m.media-amazon.com/images/I/61WFOz9XtoL._AC_SX679_.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Greenies Original Natural Dental Care Dog Treats",
                    Description = "GREENIES Canine Dental Chews are the number-one vet-recommended dental chew.* GREENIES Canine Dental Chews are proven to clean dogs’ teeth by fighting both plaque and tartar buildup, freshening breath, and maintaining healthier teeth and gums. Designed for daily treating, our dental chews are low in fat and nutritionally complete for adult dogs.",
                    Image = "https://m.media-amazon.com/images/I/616ycP4rWEL._AC_SX679_.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                 new Product
                 {
                     Id = 9,
                     CategoryId = 1,
                     Title = "Clean Code",
                     Description = "Even bad code can function. But if code isn’t clean, it can bring a development organization to its knees. Every year, countless hours and significant resources are lost because of poorly written code. But it doesn’t have to be that way. Noted software expert Robert C. Martin presents a revolutionary paradigm with Clean Code: A Handbook of Agile Software Craftsmanship. Martin has teamed up with his colleagues from Object Mentor to distill their best agile practice of cleaning code “on the fly” into a book that will instill within you the values of a software craftsman and make you a better programmer - but only if you work at it.",
                     Image = "https://m.media-amazon.com/images/I/41EYLUDaF8L.jpg",
                     DateCreated = new DateTime(2021, 1, 1)
                 }
                );


            modelBuilder.Entity<Edition>().HasData(
                    new Edition { Id = 1, Name = "Default" },
                    new Edition { Id = 2, Name = "Paperback" },
                    new Edition { Id = 3, Name = "E-Book" },
                    new Edition { Id = 4, Name = "Audiobook" },
                    new Edition { Id = 5, Name = "S" },
                    new Edition { Id = 6, Name = "M" },
                    new Edition { Id = 7, Name = "L" },
                    new Edition { Id = 8, Name = "XL" }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 7.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 1,
                    Price = 56.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 1,
                    Price = 166.66m,
                    OriginalPrice = 249.00m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 1,
                    Price = 159.99m,
                    OriginalPrice = 299m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 1,
                    Price = 35.99m,
                    OriginalPrice = 400m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 5,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 6,
                    Price = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 7,
                    Price = 49.99m,
                    OriginalPrice = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    EditionId = 5,
                    Price = 9.99m,
                    OriginalPrice = 24.99m,
                },
                 new ProductVariant
                 {
                     ProductId = 9,
                     EditionId = 2,
                     Price = 9.99m,
                     OriginalPrice = 19.99m
                 },
                new ProductVariant
                {
                    ProductId = 9,
                    EditionId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    EditionId = 4,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                }
            );

        }
    }
}
