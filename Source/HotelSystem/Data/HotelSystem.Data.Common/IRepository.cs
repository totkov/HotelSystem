namespace HotelSystem.Data.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filterExpression,
            Expression<Func<T, int>> orderBy,
            int page,
            int pageSize);

        T GetById(object id);

        int Count(Expression<Func<T, bool>> filterExpression);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
