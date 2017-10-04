using DB;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IPositionService
    {
        IEnumerable<Position> GetAll();
    }
}