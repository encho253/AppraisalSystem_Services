using DB;
using Interfaces.Repository;
using Repository.Configs;
using System.Linq;

namespace Repository
{
    public class PositionRepository : GenericRepository<Position>, IGenericRepository<Position>, IPositionRepository
    {
        public PositionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Position GetPositionByName(string position)
        {
            return this.UnitOfWork.DbContext.Positions.FirstOrDefault(x => x.Name == position);
        }
    }
}