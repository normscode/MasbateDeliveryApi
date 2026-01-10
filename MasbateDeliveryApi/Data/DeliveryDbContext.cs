using MasbateDeliveryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MasbateDeliveryApi.Data
{
    public class DeliveryDbContext : DbContext
    {
        public DeliveryDbContext(DbContextOptions<DeliveryDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.RiderProfile)
                .WithOne(r => r.User)
                .HasForeignKey<Rider>(r => r.UserId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.CustomerDeliveries)
                .WithOne(d => d.Customer)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(u => u.AssignedDeliveries)
                .WithOne(d => d.Rider)
                .HasForeignKey(d => d.RiderUserId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<DeliveryRequest>()
                .HasMany(d => d.StatusHistory)
                .WithOne(s => s.DeliveryRequest)
                .HasForeignKey(s => s.DeliveryRequestId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DeliveryRequest>()
                .Property(d => d.DeliveryType)
                .HasConversion<string>()
                .HasMaxLength(50);

            modelBuilder.Entity<DeliveryRequest>()
                .Property(d => d.Status)
                .HasConversion<string>()
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<DeliveryStatusHistory>()
                .Property(s => s.Status)
                .HasConversion<string>()
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .HasConversion<string>()
                .IsRequired();
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Rider> Riders { get; set; } = null!;
        public DbSet<DeliveryRequest> DeliveryRequests { get; set; } = null!;
        public DbSet<DeliveryStatusHistory> DeliveryStatusHistories { get; set; } = null!;
        public DbSet<Location> Locations { get; set; } = null!;
    }
}
