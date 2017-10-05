using Interfaces.Repository;

namespace Interfaces.BS
{
    public interface IBaseService
    {
        IUnitOfWork UnitOfWork { get; }
        void SaveChanges();
    }
}