namespace HotelsWebAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public int HotelId { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public float TotalPrice { get; set; }
    }
}
