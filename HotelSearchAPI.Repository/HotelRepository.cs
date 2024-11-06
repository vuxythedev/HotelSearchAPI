using Entities;
using HotelSearchAPI.RepositoryContracts;

namespace HotelSearchAPI.Repository
{
    public class HotelRepository : IHotelRepository
    {

        private static List<Hotel> _hotels = new List<Hotel>(); 

        public async Task<List<Hotel>> GetAllHotelsAsync()
        {
            return await Task.FromResult(_hotels);
        }

        public async Task<Hotel> GetHotelByIdAsync(int id)
        {
            return await Task.FromResult(_hotels.FirstOrDefault(h => h.Id == id));
        }

        public async Task CreateHotelAsync(Hotel hotel)
        {
            await Task.Run(() =>
            {
                hotel.Id = _hotels.Count + 1; 
                _hotels.Add(hotel);
            });
        }

        public async Task UpdateHotelAsync(int id, Hotel hotel)
        {
            await Task.Run(() =>
            {
                var existingHotel = _hotels.FirstOrDefault(h => h.Id == id);
                if (existingHotel != null)
                {
                    existingHotel.Name = hotel.Name;
                    existingHotel.Price = hotel.Price;
                    existingHotel.GeoLocation = hotel.GeoLocation;
                }
            });
        }

        public async Task DeleteHotelAsync(int id)
        {
            await Task.Run(() =>
            {
                var hotel = _hotels.FirstOrDefault(h => h.Id == id);
                if (hotel != null)
                {
                    _hotels.Remove(hotel);
                }
            });
        }
    }
}
