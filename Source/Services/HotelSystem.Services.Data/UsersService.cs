namespace HotelSystem.Services.Data
{
    using HotelSystem.Data.Common;
    using HotelSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public class UsersService
    {
        private IRepository<User> users;
        private IUnitOfWork uow;

        public UsersService(IRepository<User> users, IUnitOfWork uow)
        {
            this.users = users;
            this.uow = uow;
        }

        public void AddUser(User user)
        {
            this.users.Add(user);
            this.uow.Commit();
        }

        public IEnumerable<User> GetAllUsers(
            Expression<Func<User, bool>> filterExpression = null,
            Expression<Func<User, object>> orderByExpression = null,
            int? page = null,
            int? pageSize = null)
        {
            Expression<Func<User, bool>> _filterExpression = filterExpression != null ? filterExpression : (u => true);
            Expression<Func<User, object>> _orderBy = orderByExpression != null ? orderByExpression : (u => new { u.Id });
            int _page = page != null ? page.Value : 0;
            int _pageSize = pageSize != null ? pageSize.Value : this.users.Count(h => true);

            return this.users.GetAll(_filterExpression, _orderBy, _page, _pageSize);
        }
    }
}
