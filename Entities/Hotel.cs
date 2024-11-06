namespace Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public Location? GeoLocation { get; set; }
    }
}
