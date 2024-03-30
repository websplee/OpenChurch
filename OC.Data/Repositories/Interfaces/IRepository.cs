using OC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OC.Data.Repositories.Interfaces
{
    public interface IRepository<T>
        where T : class, IEntityBase, new()
    {
        IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> AllIncludingQueryable(params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAysnc();
        Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate);
        int Count();
        Task<T> GetSingle(long Id);
        IQueryable<T> GetSingle(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteWhere(Expression<Func<T, bool>> predicate);
        Task Commit();
    }
}
