namespace HotelSystem.Data.Models
{
    using System.Collections;

    public class RoomType
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection Room { get; set; }
    }
}
