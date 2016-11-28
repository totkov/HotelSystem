namespace HotelSystem.Data.Models
{
    using System;

    public class Reservation
    {
        public int Id { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        User User { get; set; }
        public int UserId { get; set; }

        Room Room { get; set; }
        public int RoomId { get; set; }
    }
}
