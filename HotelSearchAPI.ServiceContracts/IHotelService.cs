using HotelSearchAPI.ServiceContracts.DTO.Requests;
using HotelSearchAPI.ServiceContracts.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSearchAPI.ServiceContracts
{
    public interface IHotelService
    {
        Task<List<HotelResponse>> GetAllHotelsAsync();
        Task<HotelResponse> GetHotelByIdAsync(int id);
        Task CreateHotelAsync(CreateHotelRequest hotel);
        Task UpdateHotelAsync(int id, UpdateHotelRequest hotel);
        Task DeleteHotelAsync(int id);
    }
}
