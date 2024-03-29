﻿// <auto-generated />
using System;
using BlazingShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazingShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240211011431_FixSeedCategoryIcons")]
    partial class FixSeedCategoryIcons
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("BlazingShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "image",
                            Name = "Outdoor",
                            Url = "outoor"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "map-marker",
                            Name = "Dogs",
                            Url = "dogs"
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = 3,
                            Name = "E-Book"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Audiobook"
                        },
                        new
                        {
                            Id = 5,
                            Name = "S"
                        },
                        new
                        {
                            Id = 6,
                            Name = "M"
                        },
                        new
                        {
                            Id = 7,
                            Name = "L"
                        },
                        new
                        {
                            Id = 8,
                            Name = "XL"
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("EditionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Views")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EditionId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The book in your hands is a different kind of programming book. Like an entertaining video game, programming is an often challenging but always rewarding experience. This book shakes off the dusty, dull, dryness of the typical programming book, replacing it with something more exciting and flavorful: a bit of humor, a casual tone, and examples involving dragons and asteroids instead of bank accounts and employees.",
                            Image = "https://m.media-amazon.com/images/I/619vzxml9jL._SY466_.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "The C# Player's Guide (5th Edition)",
                            Views = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Pragmatic Programmer is one of those rare tech audiobooks you’ll listen, re-listen, and listen to again over the years. Whether you’re new to the field or an experienced practitioner, you’ll come away with fresh insights each and every time. ",
                            Image = "https://m.media-amazon.com/images/I/51A8l+FxFNL.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "The Pragmatic Programmer",
                            Views = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A lightweight, versatile personal filtration system, the second-generation Sawyer MINI Water Filter fits in the palm of your hand and has a total field weight of just 2 ounces. Perfect for everything from camping with the kids to traveling abroad where tap and bottle water can't be trusted, the tiny MINI provides 0.1 micron absolute filtration for clean drinking water on the go — filtering out bacteria, protozoa, and microplastics. ",
                            Image = "https://m.media-amazon.com/images/I/71Tx3ivOTYL._SX522_.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Sawyer Products SP128 Mini Water Filtration System, Single, Blue",
                            Views = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Our 100% carbon fiber trekking pole built to withstand four-season alpine terrain now features our newly redesigned FlickLock Pro adjustable technology, which is lighter, more ergonomic and easier to use.",
                            Image = "https://m.media-amazon.com/images/I/51pMA8KiXJL._AC_SY879_.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Black Diamond Alpine Carbon Cork Trekking Poles",
                            Views = 0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Since Osprey was founded in 1974, every single product design has passed through the hands of owner and founder Mike Pfotenhauer, who created his first backpack at age 16. In Santa Cruz, California, the young entrepreneur opened a retail shop in the front of his rental house where backpackers and travelers came for custom-fit, made-to-order packs constructed over several days by Mike himself. As the demand for the great-fitting packs increased, Osprey found itself relocating to its current home in Southwest Colorado. Today, Osprey is a melting pot of diverse personalities, backgrounds and abilities. All share the common belief that adventure is open to everyone and found anywhere.",
                            Image = "https://m.media-amazon.com/images/I/81VSFgVff1L._AC_SX466_.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Osprey Daylite Plus Commuter Backpack",
                            Views = 0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "12-Ounce firm-hand 100% ring spun cotton Duck dog vest with water-repellent coating quilted nylon lining for warmth and easy on and off corduroy-trimmed collar tucks into coat two rivet-reinforced pockets Carhartt label sewn on pocketfully-adjustable hook-and loop neck and chest tabs size Small 13 - 17  Neck 16 - 21 Chest",
                            Image = "https://m.media-amazon.com/images/I/717qKZOTbhS._AC_SL1500_.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Carhartt Firm Duck Insulated Dog Chore Coat Brown/Brass",
                            Views = 0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The KONG Classic is the gold standard of dog toys. Offering enrichment by helping satisfy dogs’ instinctual needs, the KONG Classic’s unique natural red rubber formula is ultra-durable with an erratic bounce that is ideal for dogs that like to chew while also fulfilling a dog’s need to play. Great for stuffing with KONG Easy Treat; Snacks or Ziggies. Made in the USA. Globally Sourced Materials.",
                            Image = "https://m.media-amazon.com/images/I/61WFOz9XtoL._AC_SX679_.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "KONG 41938 Classic Dog Toy",
                            Views = 0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "GREENIES Canine Dental Chews are the number-one vet-recommended dental chew.* GREENIES Canine Dental Chews are proven to clean dogs’ teeth by fighting both plaque and tartar buildup, freshening breath, and maintaining healthier teeth and gums. Designed for daily treating, our dental chews are low in fat and nutritionally complete for adult dogs.",
                            Image = "https://m.media-amazon.com/images/I/616ycP4rWEL._AC_SX679_.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Greenies Original Natural Dental Care Dog Treats",
                            Views = 0
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Even bad code can function. But if code isn’t clean, it can bring a development organization to its knees. Every year, countless hours and significant resources are lost because of poorly written code. But it doesn’t have to be that way. Noted software expert Robert C. Martin presents a revolutionary paradigm with Clean Code: A Handbook of Agile Software Craftsmanship. Martin has teamed up with his colleagues from Object Mentor to distill their best agile practice of cleaning code “on the fly” into a book that will instill within you the values of a software craftsman and make you a better programmer - but only if you work at it.",
                            Image = "https://m.media-amazon.com/images/I/41EYLUDaF8L.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Clean Code",
                            Views = 0
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EditionId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "EditionId");

                    b.HasIndex("EditionId");

                    b.ToTable("ProductVariant");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            EditionId = 2,
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 3,
                            OriginalPrice = 0m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 4,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 2,
                            OriginalPrice = 14.99m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 1,
                            OriginalPrice = 0m,
                            Price = 56.99m
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 1,
                            OriginalPrice = 249.00m,
                            Price = 166.66m
                        },
                        new
                        {
                            ProductId = 5,
                            EditionId = 1,
                            OriginalPrice = 299m,
                            Price = 159.99m
                        },
                        new
                        {
                            ProductId = 6,
                            EditionId = 1,
                            OriginalPrice = 400m,
                            Price = 35.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 5,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 6,
                            OriginalPrice = 0m,
                            Price = 69.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 7,
                            OriginalPrice = 59.99m,
                            Price = 49.99m
                        },
                        new
                        {
                            ProductId = 8,
                            EditionId = 5,
                            OriginalPrice = 24.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 9,
                            EditionId = 2,
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 9,
                            EditionId = 3,
                            OriginalPrice = 0m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 9,
                            EditionId = 4,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.Stats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastVisit")
                        .HasColumnType("TEXT");

                    b.Property<int>("Visits")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("BlazingShop.Shared.Product", b =>
                {
                    b.HasOne("BlazingShop.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingShop.Shared.Edition", null)
                        .WithMany("Products")
                        .HasForeignKey("EditionId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazingShop.Shared.ProductVariant", b =>
                {
                    b.HasOne("BlazingShop.Shared.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingShop.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BlazingShop.Shared.Edition", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BlazingShop.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
