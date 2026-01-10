using MasbateDeliveryApi.Enums;

namespace MasbateDeliveryApi.Models
{
    public class DeliveryRequest
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int? RiderUserId { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public string PickupAddress { get; set; } = null!;
        public string DropoffAddress { get; set; } = null!;
        public string ItemDescription { get; set; } = null!;
        public decimal? Fee { get; set; }
        public DeliveryStatus Status { get; set; } = DeliveryStatus.Pending;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public User Customer { get; set; } = null!;
        public User? Rider { get; set; }
        public List<DeliveryStatusHistory> StatusHistory { get; set; } = new();
    }
}
