using MasbateDeliveryApi.Enums;

namespace MasbateDeliveryApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public UserRole Role { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public Rider? RiderProfile { get; set; } // Null if not a rider
        public List<DeliveryRequest> CustomerDeliveries { get; set; } = new();
        public List<DeliveryRequest> AssignedDeliveries { get; set; } = new();
    }
}
