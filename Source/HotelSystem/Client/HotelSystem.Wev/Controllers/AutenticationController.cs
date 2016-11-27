namespace HotelSystem.Wev.Controllers
{
    using Data.Models;
    using Models;
    using Services.Data;
    using System.Web.Mvc;
    using ViewModels.User;

    public class AutenticationController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            AuthenticationManager.Authenticate(username, password);

            if (AuthenticationManager.LoggedUser == null)
            {
                ModelState.AddModelError("authenticationFailed", "Wrong username or password!");
                ViewData["username"] = username;

                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(UserViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                UsersService users = ServiceFactory.GetUsersService();
                User user = new User
                {
                    Username = model.Username,
                    Password = model.Password,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    Phone = model.Phone
                };
                users.AddUser(user);
                this.TempData["State"] = "User is added!";
                return RedirectToAction("Login", "Autentication");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Logout()
        {
            if (AuthenticationManager.LoggedUser == null)
            {
                return RedirectToAction("Login", "Autentication");
            }

            AuthenticationManager.Logout();

            return RedirectToAction("Login", "Autentication");
        }
    }
}