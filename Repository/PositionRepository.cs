using DB;
using Interfaces.Repository;
using Repository.Configs;

namespace Repository
{
    public class PositionRepository : GenericRepository<Position>, IGenericRepository<Position>, IPositionRepository
    {
        public PositionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}