namespace HotelSystem.Web.Filters
{
    using Data.Models;
    using Models;
    using System.Web.Mvc;
    using System.Web.Routing;

    public class OnlyFor : ActionFilterAttribute
    {
        public UserRoles Role { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (AuthenticationManager.LoggedUser == null || AuthenticationManager.LoggedUser.Role != this.Role)
            {
                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary
                {
                    { "controller", "Autentication" },
                    { "action", "Login" }
                });
            }
        }
    }
}