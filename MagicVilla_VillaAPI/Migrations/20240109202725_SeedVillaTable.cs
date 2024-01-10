using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "24/7 Concierge Service", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luxurious 5-bedroom villa with breathtaking ocean views, private pool, and exclusive amenities.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg", "Royal villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Private Chef", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secluded hilltop villa offering stunning sunset views, infinity pool, and spa services.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg", "Sunset Retreat", 4, 250.0, 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Spa Access", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charming villa surrounded by lush gardens, featuring a cozy fireplace and outdoor dining area.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg", "Garden Oasis", 3, 180.0, 450, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Water Sports Equipment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modern beachfront villa with floor-to-ceiling windows, Jacuzzi, and direct access to the sandy shores.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg", "Azure Bliss", 6, 300.0, 700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Hiking Trails Access", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic mountain retreat featuring a wood-burning fireplace, hot tub, and scenic mountain views.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg", "Mountain Lodge", 4, 220.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Private Fishing Dock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tranquil riverside villa surrounded by nature, offering fishing, bird watching, and relaxation.", "https://aabode.com/images/129/129194.780.png", "Serene Haven", 2, 150.0, 400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "City Tours Package", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek city villa with modern amenities, rooftop terrace, and proximity to cultural attractions.", "https://aabode.com/images/129/129196.780.png", "Urban Escape", 2, 180.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
