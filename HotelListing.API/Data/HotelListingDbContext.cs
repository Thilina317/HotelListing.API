using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Sri Lanka",
                    ShortName = "SL",
                },
                new Country
                {
                    Id = 2,
                    Name = "India",
                    ShortName = "IN",
                },
                new Country
                {
                    Id = 3,
                    Name = "Pakistan",
                    ShortName = "PK",
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Galadari",
                    Address = "Colombo",
                    CountryId = 1,
                    Rating = 8.9
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Tag samudra",
                    Address = "Hydrabad",
                    CountryId = 2,
                    Rating = 8.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hilton",
                    Address = "Lahore",
                    CountryId = 3,
                    Rating = 7.0
                }
            );       
        }
    }
}
