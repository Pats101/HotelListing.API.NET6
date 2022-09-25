using HotelListing.API.Data;

namespace HotelListing.API.Contracts
{
    public interface IHotelsRepository : IGenericRepository<Hotel>
    {
        public Task<Hotel> AddAsync(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Hotel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Hotel> GetAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Hotel entity)
        {
            throw new NotImplementedException();
        }
    }
}
