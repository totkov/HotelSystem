using HotelSystem.Data;
using HotelSystem.Data.Common;
using HotelSystem.Data.Models;
using HotelSystem.Services.Data;
using HotelSystem.Wev.ViewModels.Home;
using HotelSystem.Wev.ViewModels.Hotels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelSystem.Wev.Controllers
{
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