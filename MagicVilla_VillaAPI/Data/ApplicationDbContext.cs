using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Villa> Villas { get; set; }
    public DbSet<VillaNumber> VillaNumbers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Villa>().HasData(
            new Villa()
            {
                Id = 1,
                Name = "Royal villa",
                Details = "Luxurious 5-bedroom villa with breathtaking ocean views, private pool, and exclusive amenities.",
                ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg",
                Occupancy = 5,
                Rate = 200,
                Sqft = 550,
                Amenity = "24/7 Concierge Service",
                CreatedDate = DateTime.UtcNow
            },
            new Villa()
            {
                Id = 2,
                Name = "Sunset Retreat",
                Details = "Secluded hilltop villa offering stunning sunset views, infinity pool, and spa services.",
                ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg",
                Occupancy = 4,
                Rate = 250,
                Sqft = 600,
                Amenity = "Private Chef",
                CreatedDate = DateTime.UtcNow
            },

            new Villa()
            {
                Id = 3,
                Name = "Garden Oasis",
                Details = "Charming villa surrounded by lush gardens, featuring a cozy fireplace and outdoor dining area.",
                ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg",
                Occupancy = 3,
                Rate = 180,
                Sqft = 450,
                Amenity = "Spa Access",
                CreatedDate = DateTime.UtcNow
            },

            new Villa()
            {
                Id = 4,
                Name = "Azure Bliss",
                Details = "Modern beachfront villa with floor-to-ceiling windows, Jacuzzi, and direct access to the sandy shores.",
                ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg",
                Occupancy = 6,
                Rate = 300,
                Sqft = 700,
                Amenity = "Water Sports Equipment",
                CreatedDate = DateTime.UtcNow
            },

            new Villa()
            {
                Id = 5,
                Name = "Mountain Lodge",
                Details = "Rustic mountain retreat featuring a wood-burning fireplace, hot tub, and scenic mountain views.",
                ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg",
                Occupancy = 4,
                Rate = 220,
                Sqft = 500,
                Amenity = "Hiking Trails Access",
                CreatedDate = DateTime.UtcNow
            },

            new Villa()
            {
                Id = 6,
                Name = "Serene Haven",
                Details = "Tranquil riverside villa surrounded by nature, offering fishing, bird watching, and relaxation.",
                ImageUrl = "https://aabode.com/images/129/129194.780.png",
                Occupancy = 2,
                Rate = 150,
                Sqft = 400,
                Amenity = "Private Fishing Dock",
                CreatedDate = DateTime.UtcNow
            },

            new Villa()
            {
                Id = 7,
                Name = "Urban Escape",
                Details = "Sleek city villa with modern amenities, rooftop terrace, and proximity to cultural attractions.",
                ImageUrl = "https://aabode.com/images/129/129196.780.png",
                Occupancy = 2,
                Rate = 180,
                Sqft = 550,
                Amenity = "City Tours Package",
                CreatedDate = DateTime.UtcNow
            }
        );
    }
}