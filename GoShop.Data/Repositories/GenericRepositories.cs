using System.Linq.Expressions;
using GoShop.Data.DbContexts;
using GoShop.Data.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace GoShop.Data.Repositories
{
    public class GenericRepositories<T> : IGenericRepository<T> where T : class
    {
        private GoShopDbContext dbContext;

        protected readonly DbSet<T> dbSet;

        public GenericRepositories(GoShopDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
        }

        public async ValueTask<T> CreateAsync(T entity)
            => (await dbSet.AddAsync(entity)).Entity;

        public async ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await dbSet.FirstOrDefaultAsync(expression);

            if (entity == null)
                return false;
            else
            {
                dbSet.Remove(entity);
                return true;
            }
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression, string[] includes = null, bool isTracking = true)
        {
            IQueryable<T> query = expression is null ? dbSet : dbSet.Where(expression);

            if (includes != null)
                foreach (var include in includes)
                    if (!string.IsNullOrEmpty(include))
                        query = query.Include(include);

            if (!isTracking)
                query = query.AsNoTracking();

            return query;
        }

        public async ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null)
            => await GetAll(expression, includes, false).FirstOrDefaultAsync();

        public T Update(T entity)
            => (dbSet.Update(entity)).Entity;
    }
}
