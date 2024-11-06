using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSearchAPI.ServiceContracts.DTO.Requests
{
    public class HotelGeoLocationRequest // it could be record!!
    {

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Location ToLocation()
        {
            return new Location() { Latitude = Latitude, Longitude = Longitude };
        }
    }
}
