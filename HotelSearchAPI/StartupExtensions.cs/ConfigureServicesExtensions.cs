using HotelSearchAPI.Entities;
using HotelSearchAPI.Services;
using Microsoft.EntityFrameworkCore;
using HotelSearchAPI.ServiceContracts;
using HotelSearchAPI.RepositoryContracts;
using HotelSearchAPI.Repository;

namespace HotelSearchAPI.StartupExtensions.cs
{
    public  static class ConfigureServicesExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HotelDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            #region IOC
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<IHotelService, HotelService>();
            #endregion

            return services;       
        }
    }
}
