namespace HotelSystem.Data.Models
{
    using System.Collections.Generic;

    public class User
    {
        private ICollection<Reservation> reservations;

        public User()
        {
            this.reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<Reservation> Reservations
        {
            get { return this.reservations; }
            set { this.reservations = value; }
        }
    }
}
