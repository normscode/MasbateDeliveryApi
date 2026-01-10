using MasbateDeliveryApi.Enums;

namespace MasbateDeliveryApi.Models
{
    public class DeliveryStatusHistory
    {
        public int Id { get; set; }
        public int DeliveryRequestId { get; set; }
        public DeliveryStatus Status { get; set; } = DeliveryStatus.Pending;
        public string? Note { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public DeliveryRequest DeliveryRequest { get; set; } = null!;
    }
}
