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
            Expression<Func<T, bool>> filterExpression = null,
            Expression<Func<T, object>> orderBy = null,
            int? page = null,
            int? pageSize = null)
        {
            IQueryable<T> query = this.DbSet;

            if (filterExpression != null)
            {
                query = query.Where(filterExpression);
            }

            if (orderBy != null)
            {
                query = query.OrderBy(orderBy);
            }

            if (page != null && pageSize != null)
            {
                query = query
                        .Skip(page.Value * pageSize.Value)
                        .Take(pageSize.Value);
            }

            return query.ToList();
        }

        public T GetById(object id)
        {
            return this.DbSet.Find(id);
        }

        public int Count(Expression<Func<T, bool>> filterExpression = null)
        {
            IQueryable<T> query = this.DbSet;

            if (filterExpression != null)
            {
                query = query.Where(filterExpression);
            }

            return query.Count();
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
