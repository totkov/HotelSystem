namespace HotelSystem.Web.Controllers
{
    using HotelSystem.Data.Models;
    using HotelSystem.Services.Data;
    using HotelSystem.Web.ViewModels.Home;
    using HotelSystem.Web.ViewModels.Hotels;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HotelsService hotels = ServiceFactory.GetHotelsService();
            IndexViewModel model = new IndexViewModel();
            foreach (Hotel hotel in hotels.GetAllHotels())
            {
                HotelViewModel hotelVM = new HotelViewModel
                {
                    Name = hotel.Name,
                    Address = hotel.Address,
                    Stars = hotel.Stars
                };
                model.Hotels.Add(hotelVM);
            }

            return View(model);
        }
    }
}