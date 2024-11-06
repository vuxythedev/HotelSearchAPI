using Entities;

namespace HotelSearchAPI.RepositoryContracts
{
    public interface IHotelRepository
    {
        Task<List<Hotel>> GetAllHotelsAsync();
        Task<Hotel> GetHotelByIdAsync(int id);
        Task CreateHotelAsync(Hotel hotel);
        Task UpdateHotelAsync(int id, Hotel hotel);
        Task DeleteHotelAsync(int id);

    }
}
