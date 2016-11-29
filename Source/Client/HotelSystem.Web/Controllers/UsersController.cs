namespace HotelSystem.Web.Controllers
{
    using System.Collections.Generic;
    using Services.Data;
    using System.Web.Mvc;
    using ViewModels.User;
    using Data.Models;
    using Filters;

    [OnlyFor(Role = UserRoles.Admin)]
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

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(UserViewModel user)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return this.RedirectToAction("List");
        }
    }
}