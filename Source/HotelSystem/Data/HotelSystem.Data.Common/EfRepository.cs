namespace HotelSystem.Data.Common
{
    using System;
    using System.Linq;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public class EfRepository<T> : IRepository<T> where T : class
    {
        public EfRepository(DbContext context)
        {
            this.Context = context;
            this.DbSet = this.Context.Set<T>();
        }

        protected DbContext Context { get; set; }
        protected DbSet<T> DbSet { get; set; }

        public IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filterExpression,
            Expression<Func<T, int>> orderBy,
            int page,
            int pageSize)
        {
            return this.DbSet
                .Where(filterExpression)
                .OrderBy(orderBy)
                .Skip(page * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public T GetById(object id)
        {
            return this.DbSet.Find(id);
        }

        public int Count(Expression<Func<T, bool>> filterExpression)
        {
            return this.DbSet
                .Where(filterExpression)
                .Count();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> filterExpression)
        {
            return this.DbSet.FirstOrDefault(filterExpression);
        }

        public void Add(T entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Added;
        }

        public void Update(T entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Deleted;
        }
    }
}
