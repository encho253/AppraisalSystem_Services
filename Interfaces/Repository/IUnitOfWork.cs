using DB;

namespace Interfaces.Repository
{
    public interface IUnitOfWork
    {
        IAccountRepository AccountRepository { get; }
        AppraisalDbContext DbContext { get; }
        void SaveChanges();
    }
}