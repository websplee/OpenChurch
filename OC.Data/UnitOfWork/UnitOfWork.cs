using OC.Data.Repositories;
using OC.Data.Repositories.Interfaces;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace OC.Data.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class, IEntityBase, new()
    {
        readonly OCDbContext _context;
        readonly IHttpContextAccessor _httpAccessor;

        IRepository<T> _entity;

        public UnitOfWork(OCDbContext context, IHttpContextAccessor httpAccessor)
        {
            _context = context;
            _httpAccessor = httpAccessor;
        }

        public IRepository<T> Entity
        {
            get
            {
                if (_entity == null)
                {
                    _entity = new Repository<T>(_context, _httpAccessor);
                }

                return _entity;
            }
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
