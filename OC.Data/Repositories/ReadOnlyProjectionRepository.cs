using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using OC.Data.Repositories.Interfaces;
using System.Linq.Expressions;

namespace OC.Data.Repositories
{
    public class ReadOnlyProjectionRepository<TEntity, TDto> : IReadOnlyProjectionRepository<TEntity, TDto>
    where TEntity : class
    where TDto : class
    {
        private readonly OCDbContext _context;
        private readonly IMapper _mapper;

        public ReadOnlyProjectionRepository(OCDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<TDto>> GetAllAsync()
        {
            return _context.Set<TEntity>().ProjectTo<TDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public Task<TDto?> GetByIdAsync(long id)
        {
            return _context.Set<TEntity>()
                .Where(e => EF.Property<long>(e, "Id") == id)
                .ProjectTo<TDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public Task<List<TDto>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>()
                .Where(predicate)
                .ProjectTo<TDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public Task<TDto?> GetSingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>()
                .Where(predicate)
                .ProjectTo<TDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public IQueryable<TDto> Query()
        {
            return _context.Set<TEntity>().ProjectTo<TDto>(_mapper.ConfigurationProvider);
        }

        public IQueryable<TDto> FindQueryable(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>()
                .Where(predicate)
                .ProjectTo<TDto>(_mapper.ConfigurationProvider);
        }
    }

}
