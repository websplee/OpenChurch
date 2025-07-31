using OC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OC.Data.Repositories.Interfaces
{
    public interface IReadOnlyProjectionRepository<TEntity, TDto>
    where TEntity : class
    where TDto : class
    {
        Task<List<TDto>> GetAllAsync();
        Task<TDto?> GetByIdAsync(long id);
        Task<List<TDto>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TDto?> GetSingleAsync(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TDto> Query();
        IQueryable<TDto> FindQueryable(Expression<Func<TEntity, bool>> predicate);
    }
}
