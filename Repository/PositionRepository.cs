using DB;
using Interfaces.Repository;

namespace Repository
{
    public class PositionRepository : GenericRepository<Position>, IGenericRepository<Position>, IPositionRepository
    {
        public PositionRepository(AppraisalDbContext dbContext) : base(dbContext)
        {
        }
    }
}