namespace HotelSystem.Services.Data
{
    using HotelSystem.Data.Common;
    using HotelSystem.Data.Models;
    using System.Linq;

    public class AuthenticationService
    {
        private IRepository<User> users;

        public AuthenticationService(IRepository<User> users)
        {
            this.users = users;
        }

        public User LoggedUser { get; private set; }

        public void AuthenticateUser(string username, string password)
        {
            this.LoggedUser = users.GetAll(
                    u => u.Username == username && u.Password == password,
                    u => u.Id,
                    0,
                    1)
                .First();
        }
    }
}
