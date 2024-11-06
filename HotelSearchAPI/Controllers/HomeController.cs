using Entities;
using HotelSearchAPI.ServiceContracts.DTO.Requests;
using HotelSearchAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly HotelService _hotelService;

        public HomeController(HotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateHotelAsync([FromBody] CreateHotelRequest hotel)
        {
           await  _hotelService.CreateHotelAsync(hotel);
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetHotelById(int id)
        {
            var hotel = _hotelService.GetHotelByIdAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return Ok(hotel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHotel(int id, [FromBody] UpdateHotelRequest hotel)
        {
            var existingHotel = _hotelService.GetHotelByIdAsync(id);
            if (existingHotel == null)
            {
                return NotFound();
            }
           await _hotelService.UpdateHotelAsync(id, hotel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            await _hotelService.DeleteHotelAsync(id);
            return NoContent();
        }
    }
}
