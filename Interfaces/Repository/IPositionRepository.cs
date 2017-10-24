using DB;

namespace Interfaces.Repository
{
    public interface IPositionRepository : IGenericRepository<Position>
    {
        Position GetPositionByName(string position);
    }
}