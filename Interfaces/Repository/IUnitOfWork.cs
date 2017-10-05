using DB;

namespace Interfaces.Repository
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        AppraisalDbContext DbContext { get; }
        IEvaluationTemplateRepository EvaluationTemplateRepository { get; }
        IPositionRepository PositionRepository { get; }
        void SaveChanges();
    }
}