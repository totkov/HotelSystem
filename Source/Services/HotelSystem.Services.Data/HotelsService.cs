namespace HotelSystem.Services.Data
{
    using HotelSystem.Data.Common;
    using HotelSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public class HotelsService
    {
        private IRepository<Hotel> hotels;
        private IUnitOfWork uow;

        public HotelsService(IRepository<Hotel> hotels, IUnitOfWork uow)
        {
            this.hotels = hotels;
            this.uow = uow;
        }

        public void AddHotel(Hotel hotel)
        {
            this.hotels.Add(hotel);
            this.uow.Commit();
        }

        public IEnumerable<Hotel> GetAllHotels(
            Expression<Func<Hotel, bool>> filterExpression = null,
            Expression<Func<Hotel, object>> orderByExpression = null,
            int? page = null,
            int? pageSize = null)
        {
            Expression<Func<Hotel, bool>> _filterExpression = filterExpression != null ? filterExpression : (h => true);
            Expression<Func<Hotel, object>> _orderBy = orderByExpression != null ? orderByExpression : (h => new { h.Id });
            int _page = page != null ? page.Value : 0;
            int _pageSize = pageSize != null ? pageSize.Value : this.hotels.Count(h => true);

            return this.hotels.GetAll(_filterExpression, _orderBy, _page, _pageSize);
        }
    }
}
