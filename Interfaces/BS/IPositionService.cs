using DB;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IPositionService : IBaseService
    {
        IEnumerable<string> GetAllPositionsByName();
        IEnumerable<Position> GetAllPositions();
        Position FindPositon(int id);
        void UpdatePosition(int id, string positionName);
        void AddPosition(string positionName);
    }
}