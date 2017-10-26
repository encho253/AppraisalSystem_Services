using System;
using System.Collections.Generic;
using BS.Configs;
using DB;
using Interfaces.BS;
using WCF.Interfaces.WCF;

namespace WCF
{
    public class PositionService : IPositionWcfService
    {
        public IEnumerable<Position> GetAllPositions()
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();

                IPositionService positionService = dataContainer.Resolve<IPositionService>();
                return positionService.GetAllPositions();
            }
        }

        public IEnumerable<string> GetAllPositionsByName()
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();

                IPositionService positionService = dataContainer.Resolve<IPositionService>();
                return positionService.GetAllPositionsByName();
            }
        }
    }
}