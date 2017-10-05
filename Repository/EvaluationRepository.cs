using DB;
using Interfaces.Repository;
using Repository.Configs;

namespace Repository
{
    public class EvaluationRepository : GenericRepository<Evaluation>, IGenericRepository<Evaluation>, IEvaluationRepository
    {
        public EvaluationRepository(AppraisalDbContext dbContext) : base(dbContext)
        {
        }
    }
}