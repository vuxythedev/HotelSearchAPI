using Entities;
using HotelSearchAPI.ServiceContracts.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSearchAPI.ServiceContracts.DTO.Requests
{
    public class UpdateHotelRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public HotelGeoLocationRequest GeoLocation { get; set; }

        public Hotel ToHotel()
        {
            return new Hotel() { Name = Name, Price = Price, GeoLocation = GeoLocation.ToLocation() };
        }
    }
}
