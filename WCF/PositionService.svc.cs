using System;
using System.Collections.Generic;
using BS.Configs;
using DB;
using Interfaces.BS;
using WCF.Interfaces.WCF;
using Repository.Configs;

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

        //public IEnumerable<> GetAllPositionsByName()
        //{
        //    using (IUnityManagerModule dataContainer = new UnityManagerModule())
        //    {
        //        dataContainer.Init();

        //        IPositionService positionService = dataContainer.Resolve<IPositionService>();
        //        return positionService.GetAllPositionsByName();
        //    }
        //}

        public void UpdatePosition(int id, string positionName)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();

                IPositionService positionService = dataContainer.Resolve<IPositionService>();
                positionService.UpdatePosition(id, positionName);

                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.SaveChanges();
            }
        }

        public void AddPosition(string positionName)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();

                IPositionService positionService = dataContainer.Resolve<IPositionService>();
                positionService.AddPosition(positionName);

                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.SaveChanges();
            }
        }
    }
}