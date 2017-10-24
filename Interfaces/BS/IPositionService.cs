using DB;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IPositionService : IBaseService
    {
        string[] GetAll();
        Position FindPositon(int id);
    }
}