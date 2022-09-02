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
                    Name = "Zimbabwe",
                    ShortName = "Zw"
                },
                new Country
                {
                    Id = 2,
                    Name = "South Africa",
                    ShortName = "SA"
                },
                new Country
                {
                    Id = 3,
                    Name = "Canada",
                    ShortName = "CA"
                },
                new Country
                {
                    Id = 4,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 5,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    Id = 6,
                    Name = "Cayman Island",
                    ShortName = "CI"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Matetsi Victoria Falls",
                    Address = "Harare",
                    CountryId = 1,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Tintswalo Atlantic",
                    Address = "Cape Town",
                    CountryId = 2,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Four Seasons Hotel Toronto",
                    Address = "Toronto",
                    CountryId = 3,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 4,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    CountryId = 5,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 6,
                    Name = "Grand Palldium",
                    Address = "Nassua",
                    CountryId = 6,
                    Rating = 4
                }
                );
        }
    }
}
