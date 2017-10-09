using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using System.Collections.Generic;

namespace BS
{
    public class PositionService : BaseService, IBaseService, IPositionService
    {
        public PositionService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.PositionRepository = this.UnityManager.Resolve<IPositionRepository>();
        }

        public IPositionRepository PositionRepository { get; set; }

        public IEnumerable<Position> GetAll()
        {
            IEnumerable<Position> positions = this.PositionRepository.GetAllRecords();

            return positions;
        }

        public Position FindPositon(int id)
        {
            return this.PositionRepository.GetFirstOrDefault(id);
        }
    }
}