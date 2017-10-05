﻿using DB;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IPositionService : IBaseService
    {
        IEnumerable<Position> GetAll();
        Position FindPositon(int id);
    }
}