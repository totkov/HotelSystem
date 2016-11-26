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

        public HotelsService(IRepository<Hotel> hotels)
        {
            this.hotels = hotels;
        }

        public IEnumerable<Hotel> GetAllHotels(
            Expression<Func<Hotel, bool>> filterExpression = null,
            Expression<Func<Hotel, int>> orderByExpression = null,
            int? page = null,
            int? pageSize = null)
        {
            Expression <Func<Hotel, bool>> _filterExpression = filterExpression != null ? filterExpression : (h => true);
            Expression<Func<Hotel, int>> _orderBy = orderByExpression != null ? orderByExpression : (h => h.Id);
            int _page = page != null ? page.Value : 0;
            int _pageSize = pageSize != null ? pageSize.Value : this.hotels.Count(h => true);

            return this.hotels.GetAll(_filterExpression, _orderBy, _page, _pageSize);
        }
    }
}
