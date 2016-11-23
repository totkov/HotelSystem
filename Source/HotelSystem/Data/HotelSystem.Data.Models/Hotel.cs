namespace HotelSystem.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;

    public class Hotel
    {
       
        public Hotel()
        {

            this.rooms = new HashSet<Room>();
        }

        private ICollection<Room> rooms;

        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int Stars { get; set; }

        public virtual ICollection <Room> Rooms
        {
            get { return this.rooms; }
            set { this.rooms = value; }
        }
    }
}
