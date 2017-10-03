using DB;

namespace Interfaces.Repository
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        AppraisalDbContext DbContext { get; }
        void SaveChanges();
    }
}