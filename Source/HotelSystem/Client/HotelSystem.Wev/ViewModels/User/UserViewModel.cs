namespace HotelSystem.Wev.ViewModels.User
{
    using System.ComponentModel.DataAnnotations;

    public class UserViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
    }
}