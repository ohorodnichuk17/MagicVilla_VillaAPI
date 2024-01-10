﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Occupancy")
                        .HasColumnType("integer");

                    b.Property<double>("Rate")
                        .HasColumnType("double precision");

                    b.Property<int>("Sqft")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "24/7 Concierge Service",
                            CreatedDate = new DateTime(2024, 1, 9, 20, 31, 37, 406, DateTimeKind.Utc).AddTicks(3380),
                            Details = "Luxurious 5-bedroom villa with breathtaking ocean views, private pool, and exclusive amenities.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg",
                            Name = "Royal villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "Private Chef",
                            CreatedDate = new DateTime(2024, 1, 9, 20, 31, 37, 406, DateTimeKind.Utc).AddTicks(3380),
                            Details = "Secluded hilltop villa offering stunning sunset views, infinity pool, and spa services.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg",
                            Name = "Sunset Retreat",
                            Occupancy = 4,
                            Rate = 250.0,
                            Sqft = 600,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "Spa Access",
                            CreatedDate = new DateTime(2024, 1, 9, 20, 31, 37, 406, DateTimeKind.Utc).AddTicks(3380),
                            Details = "Charming villa surrounded by lush gardens, featuring a cozy fireplace and outdoor dining area.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg",
                            Name = "Garden Oasis",
                            Occupancy = 3,
                            Rate = 180.0,
                            Sqft = 450,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "Water Sports Equipment",
                            CreatedDate = new DateTime(2024, 1, 9, 20, 31, 37, 406, DateTimeKind.Utc).AddTicks(3390),
                            Details = "Modern beachfront villa with floor-to-ceiling windows, Jacuzzi, and direct access to the sandy shores.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg",
                            Name = "Azure Bliss",
                            Occupancy = 6,
                            Rate = 300.0,
                            Sqft = 700,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "Hiking Trails Access",
                            CreatedDate = new DateTime(2024, 1, 9, 20, 31, 37, 406, DateTimeKind.Utc).AddTicks(3390),
                            Details = "Rustic mountain retreat featuring a wood-burning fireplace, hot tub, and scenic mountain views.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg",
                            Name = "Mountain Lodge",
                            Occupancy = 4,
                            Rate = 220.0,
                            Sqft = 500,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Amenity = "Private Fishing Dock",
                            CreatedDate = new DateTime(2024, 1, 9, 20, 31, 37, 406, DateTimeKind.Utc).AddTicks(3390),
                            Details = "Tranquil riverside villa surrounded by nature, offering fishing, bird watching, and relaxation.",
                            ImageUrl = "https://aabode.com/images/129/129194.780.png",
                            Name = "Serene Haven",
                            Occupancy = 2,
                            Rate = 150.0,
                            Sqft = 400,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Amenity = "City Tours Package",
                            CreatedDate = new DateTime(2024, 1, 9, 20, 31, 37, 406, DateTimeKind.Utc).AddTicks(3390),
                            Details = "Sleek city villa with modern amenities, rooftop terrace, and proximity to cultural attractions.",
                            ImageUrl = "https://aabode.com/images/129/129196.780.png",
                            Name = "Urban Escape",
                            Occupancy = 2,
                            Rate = 180.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
