using DB;
using Interfaces.Repository;
using Repository.Configs;

namespace Repository
{
    public class ResultRepository : GenericRepository<Result>, IGenericRepository<Result>, IResultRepository
    {
        public ResultRepository(AppraisalDbContext dbContext) : base(dbContext)
        {
        }
    }
}