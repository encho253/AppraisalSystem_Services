using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BS
{
    public class PositionService : BaseService, IBaseService, IPositionService
    {
        public PositionService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.PositionRepository = this.UnityManager.Resolve<IPositionRepository>();
        }

        public IPositionRepository PositionRepository { get; set; }

        public IEnumerable<string> GetAllPositionsByName()
        {
            IEnumerable<Position> positions = GetAllPositions();

            return positions.Select(p => p.Name).ToList();
        }

        public IEnumerable<Position> GetAllPositions()
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