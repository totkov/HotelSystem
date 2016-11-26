namespace HotelSystem.Data
{
    using System.Data.Entity;
    using HotelSystem.Data.Models;

    public class HotelSystemDbContext : DbContext
    {
        public HotelSystemDbContext()
            : base("HotelSystemDbConnection")
        {
        }

        public virtual IDbSet<Hotel> Hotels {get;set;}

        public virtual IDbSet<Room> Rooms { get; set; }

        public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<RoomType> RoomTypes { get; set; }

        public virtual IDbSet<Reservation> Reservations { get; set; }
    }
}
