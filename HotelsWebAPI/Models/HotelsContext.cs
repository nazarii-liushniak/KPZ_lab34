using Microsoft.EntityFrameworkCore;

namespace HotelsWebAPI.Models
{
    public class HotelsContext : DbContext
    {
        public HotelsContext(DbContextOptions<HotelsContext> options) : base(options) {}

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
