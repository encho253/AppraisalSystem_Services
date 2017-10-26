using DB;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IPositionService : IBaseService
    {
        IEnumerable<string> GetAllPositionsByName();
        IEnumerable<Position> GetAllPositions();
        Position FindPositon(int id);
    }
}