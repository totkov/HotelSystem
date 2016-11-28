namespace HotelSystem.Web.Controllers
{
    using System.Collections.Generic;
    using Services.Data;
    using System.Web.Mvc;
    using ViewModels.User;
    using Data.Models;

    public class UsersController : Controller
    {
        public ActionResult List()
        {
            UsersService users = ServiceFactory.GetUsersService();
            List<UserViewModel> model = new List<UserViewModel>();
            foreach (User user in users.GetAllUsers())
            {
                UserViewModel userVM = new UserViewModel
                {
                    Id = user.Id,
                    Username = user.Username,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Address = user.Address,
                    Phone = user.Phone,
                    Role = user.Role
                };
                model.Add(userVM);
            }

            return View(model);
        }
    }
}