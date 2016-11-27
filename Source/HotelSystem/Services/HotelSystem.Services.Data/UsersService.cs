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
    }
}
