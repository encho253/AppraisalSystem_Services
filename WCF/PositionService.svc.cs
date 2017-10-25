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