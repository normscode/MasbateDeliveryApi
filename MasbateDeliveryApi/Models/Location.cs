namespace MasbateDeliveryApi.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string AddressLine { get; set; } = null!;
        public string City { get; set; } = "Masbate City";
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
