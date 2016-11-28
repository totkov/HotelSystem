namespace HotelSystem.Web.ViewModels.User
{
    using Data.Models;
    using System.ComponentModel.DataAnnotations;

    public class UserViewModel
    {
        public int Id { get; set; }

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

        [Required]
        public UserRoles Role { get; set; }
    }
}