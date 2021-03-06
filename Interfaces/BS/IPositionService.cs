﻿using DB;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IPositionService : IBaseService
    {
        IEnumerable<Position> GetAllPositions();
        Position FindPositon(int id);
        Position GetPositionByName(string positionName);
        void UpdatePosition(int id, string positionName);
        void AddPosition(string positionName);      
    }
}