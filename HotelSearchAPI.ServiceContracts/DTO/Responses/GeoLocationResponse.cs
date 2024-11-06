using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSearchAPI.ServiceContracts.DTO.Responses
{
    public class GeoLocationResponse
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public static class GeoLocationExtensions
    {

        public static GeoLocationResponse ToGeoLocationResponse(this Location location)
        {
            return new GeoLocationResponse
            {
                Latitude = location.Latitude,
                Longitude = location.Longitude,
            };
        }

    }
 }
