namespace HotelSystem.Services.Data
{
    using HotelSystem.Data;
    using HotelSystem.Data.Models;
    using HotelSystem.Data.Common;

    public class ServiceFactory
    {
        public static AuthenticationService GetAutenticationService()
        {
            HotelSystemDbContext dbContext = new HotelSystemDbContext();
            IRepository<User> users = new EfRepository<User>(dbContext);
            return new AuthenticationService(users);
        }

        public static HotelsService GetHotelsService()
        {
            HotelSystemDbContext dbContext = new HotelSystemDbContext();
            IRepository<Hotel> hotels = new EfRepository<Hotel>(dbContext);
            return new HotelsService(hotels);
        }

        public static UsersService GetUsersService()
        {
            HotelSystemDbContext dbContext = new HotelSystemDbContext();
            IRepository<User> users = new EfRepository<User>(dbContext);
            IUnitOfWork uow = new EfUnitOfWork(dbContext);
            return new UsersService(users, uow);
        }
    }
}
