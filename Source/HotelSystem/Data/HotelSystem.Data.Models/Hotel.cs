namespace HotelSystem.Data.Models
{
    using System.Collections;

    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int Stars { get; set; }

        public virtual ICollection Room { get; set; }
    }
}
