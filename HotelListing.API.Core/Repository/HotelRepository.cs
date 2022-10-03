using AutoMapper;
using HotelListing.API.Core.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Core.Repository
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}