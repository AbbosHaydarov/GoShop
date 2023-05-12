using GoShop.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Data.Repositories
{
    public class GenericRepositories<T> : IGenericRepository<T> where T : class
    {
        public GenericRepositories() { }
        public ValueTask<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression, string[] includes = null, bool isTracking = true)
        {
            throw new NotImplementedException();
        }

        public ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
