using OC.Data.Repositories.Interfaces;
using OC.Domain.Interfaces;
using System.Threading.Tasks;

namespace OC.Data.UnitOfWork.Interfaces
{
    public interface IUnitOfWork<T> where T : class, IEntityBase, new()
    {
        IRepository<T> Entity { get; }

        Task SaveChangesAsync();
    }
}
