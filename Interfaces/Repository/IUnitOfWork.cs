using DB;

namespace Interfaces.Repository
{
    public interface IUnitOfWork
    {
        AppraisalDbContext DbContext { get; }
        void SaveChanges();
    }
}