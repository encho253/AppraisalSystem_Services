using BS.Configs;
using Interfaces.BS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF.Interfaces.WCF;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PositionService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PositionService.svc or PositionService.svc.cs at the Solution Explorer and start debugging.
    public class PositionService : IPositionWcfService
    {
        public string[] GetAll()
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();

                IPositionService positionService = dataContainer.Resolve<IPositionService>();
                return positionService.GetAll();
            }
        }
    }
}