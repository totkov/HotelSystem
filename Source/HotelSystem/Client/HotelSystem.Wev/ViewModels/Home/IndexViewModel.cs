namespace HotelSystem.Wev.ViewModels.Home
{
    using Hotels;
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public IndexViewModel()
        {
            this.Hotels = new List<HotelViewModel>();
        }

        public List<HotelViewModel> Hotels { get; set; }
    }
}