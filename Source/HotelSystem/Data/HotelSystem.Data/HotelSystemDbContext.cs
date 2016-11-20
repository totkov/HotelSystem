namespace HotelSystem.Data
{
    using System.Data.Entity;
    using HotelSystem.Data.Models;


    class HotelSystemDbContext : DbContext
    {
        public HotelSystemDbContext()
            : base()
        {

        }

        public IDbSet<Hotel> Hotels {get;set;}
        public IDbSet<Room> Rooms { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<RoomType> RoomTypes { get; set; }
        public IDbSet<Reservation> Reservations { get; set; }

    }
}
