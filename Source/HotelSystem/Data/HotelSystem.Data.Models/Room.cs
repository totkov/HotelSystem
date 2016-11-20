namespace HotelSystem.Data.Models
{
    using System.Collections;

    public class Room
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int NumberOfPeople { get; set; }
        public string Description { get; set; }

        Hotel Hotel { get; set; }
        public int HotelId { get; set; }

        RoomType RoomType { get; set; }
        public int RoomTypeId { get; set; }

        public virtual ICollection Reservation { get; set; }


    }
}
