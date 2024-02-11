using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazingShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixProductSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "S");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "M");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "L");

            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "XL" });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 6 },
                column: "Price",
                value: 35.99m);

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 3, 3, 0m, 6.99m },
                    { 4, 3, 0m, 6.99m }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "A lightweight, versatile personal filtration system, the second-generation Sawyer MINI Water Filter fits in the palm of your hand and has a total field weight of just 2 ounces. Perfect for everything from camping with the kids to traveling abroad where tap and bottle water can't be trusted, the tiny MINI provides 0.1 micron absolute filtration for clean drinking water on the go — filtering out bacteria, protozoa, and microplastics. ", "https://m.media-amazon.com/images/I/71Tx3ivOTYL._SX522_.jpg", "Sawyer Products SP128 Mini Water Filtration System, Single, Blue" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Our 100% carbon fiber trekking pole built to withstand four-season alpine terrain now features our newly redesigned FlickLock Pro adjustable technology, which is lighter, more ergonomic and easier to use.", "https://m.media-amazon.com/images/I/51pMA8KiXJL._AC_SY879_.jpg", "Black Diamond Alpine Carbon Cork Trekking Poles" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Since Osprey was founded in 1974, every single product design has passed through the hands of owner and founder Mike Pfotenhauer, who created his first backpack at age 16. In Santa Cruz, California, the young entrepreneur opened a retail shop in the front of his rental house where backpackers and travelers came for custom-fit, made-to-order packs constructed over several days by Mike himself. As the demand for the great-fitting packs increased, Osprey found itself relocating to its current home in Southwest Colorado. Today, Osprey is a melting pot of diverse personalities, backgrounds and abilities. All share the common belief that adventure is open to everyone and found anywhere.", "https://m.media-amazon.com/images/I/81VSFgVff1L._AC_SX466_.jpg", "Osprey Daylite Plus Commuter Backpack" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "Image", "Title" },
                values: new object[] { 3, "12-Ounce firm-hand 100% ring spun cotton Duck dog vest with water-repellent coating quilted nylon lining for warmth and easy on and off corduroy-trimmed collar tucks into coat two rivet-reinforced pockets Carhartt label sewn on pocketfully-adjustable hook-and loop neck and chest tabs size Small 13 - 17  Neck 16 - 21 Chest", "https://m.media-amazon.com/images/I/717qKZOTbhS._AC_SL1500_.jpg", "Carhartt Firm Duck Insulated Dog Chore Coat Brown/Brass" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "The KONG Classic is the gold standard of dog toys. Offering enrichment by helping satisfy dogs’ instinctual needs, the KONG Classic’s unique natural red rubber formula is ultra-durable with an erratic bounce that is ideal for dogs that like to chew while also fulfilling a dog’s need to play. Great for stuffing with KONG Easy Treat; Snacks or Ziggies. Made in the USA. Globally Sourced Materials.", "https://m.media-amazon.com/images/I/61WFOz9XtoL._AC_SX679_.jpg", "KONG 41938 Classic Dog Toy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "GREENIES Canine Dental Chews are the number-one vet-recommended dental chew.* GREENIES Canine Dental Chews are proven to clean dogs’ teeth by fighting both plaque and tartar buildup, freshening breath, and maintaining healthier teeth and gums. Designed for daily treating, our dental chews are low in fat and nutritionally complete for adult dogs.", "https://m.media-amazon.com/images/I/616ycP4rWEL._AC_SX679_.jpg", "Greenies Original Natural Dental Care Dog Treats" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "PC");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "PlayStation");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Xbox");

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 6 },
                column: "Price",
                value: 73.74m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.", "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd., later known as Pentax Corporation, between 1964 and 1976.", "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg", "Pentax Spotmatic" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "Image", "Title" },
                values: new object[] { 2, "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "EditionId", "Image", "IsDeleted", "IsPublic", "Title", "Views" },
                values: new object[] { 9, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", null, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", false, false, "Day of the Tentacle", 0 });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[] { 5, 9, 0m, 14.99m });
        }
    }
}
