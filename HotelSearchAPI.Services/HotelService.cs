using Entities;
using HotelSearchAPI.Repository;
using HotelSearchAPI.RepositoryContracts;
using HotelSearchAPI.ServiceContracts;
using HotelSearchAPI.ServiceContracts.DTO.Requests;
using HotelSearchAPI.ServiceContracts.DTO.Responses;

namespace HotelSearchAPI.Services
{
    public class HotelService : IHotelService
    {
        private readonly HotelRepository _hotelRepository;

        public HotelService(HotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public async Task<List<HotelResponse>> GetAllHotelsAsync()
        {
            List<HotelResponse> hotelResponseList = new List<HotelResponse>();

            var hotels = await _hotelRepository.GetAllHotelsAsync();

            foreach(var hotel in hotels)
            {
                hotelResponseList.Add(hotel.ToHotelResponse());
            }

            return hotelResponseList;
        }

        public async Task<HotelResponse> GetHotelByIdAsync(int id)
        {
            var hotel =  await _hotelRepository.GetHotelByIdAsync(id);

            return hotel.ToHotelResponse();
        }

        public async Task CreateHotelAsync(CreateHotelRequest hotel)
        {
            await _hotelRepository.CreateHotelAsync(hotel.ToHotel());
        }

        public async Task UpdateHotelAsync(int id, UpdateHotelRequest hotel)
        {
            await _hotelRepository.UpdateHotelAsync(id, hotel.ToHotel());
        }

        public async Task DeleteHotelAsync(int id)
        {
            await _hotelRepository.DeleteHotelAsync(id);
        }

        public void CreateHotelAsync(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
