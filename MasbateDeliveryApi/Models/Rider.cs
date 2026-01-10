namespace MasbateDeliveryApi.Models
{
    public class Rider
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string VehicleType { get; set; } = null!;
        public bool IsVerified { get; set; } = false;
        public bool IsAvailable { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        //Navigation Property
        public User User { get; set; } = null!;
    }
}
