using Microsoft.EntityFrameworkCore;


namespace HotelSearchAPI.Entities
{
    public  class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }
    }
}
