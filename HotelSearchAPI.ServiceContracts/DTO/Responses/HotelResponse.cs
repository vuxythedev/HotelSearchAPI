using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSearchAPI.ServiceContracts.DTO.Responses
{
    public class HotelResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public GeoLocationResponse? GeoLocation { get; set; }
    }

    public static class HotelExtensions
    {
        public static HotelResponse ToHotelResponse(this Hotel hotel)
        {
            return new HotelResponse
            {
                Id = hotel.Id,
                Name = hotel.Name,
                Price = hotel.Price,
                GeoLocation = hotel.GeoLocation.ToGeoLocationResponse(),

            };

        }
    }
}
