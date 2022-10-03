using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
