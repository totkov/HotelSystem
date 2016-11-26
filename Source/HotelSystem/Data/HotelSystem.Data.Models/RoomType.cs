namespace HotelSystem.Data.Models
{
    using System.Collections.Generic;

    public class RoomType
    {
        private ICollection<Room> rooms;

        public RoomType()
        {
            this.rooms = new HashSet<Room>();
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Room> Rooms
        {
            get { return this.rooms; }
            set { this.rooms = value; }
        }
    }
}
