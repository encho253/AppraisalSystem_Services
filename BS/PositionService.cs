using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using System;
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

        public IEnumerable<Position> GetAllPositions()
        {
            IEnumerable<Position> positions = this.PositionRepository.GetAllRecords();

            return positions;
        }

        public Position FindPositon(int id)
        {
            return this.PositionRepository.GetFirstOrDefault(id);
        }

        public Position GetPositionByName(string positionName)
        {
            return this.PositionRepository.GetPositionByName(positionName);
        }

        public void UpdatePosition(int id, string positionName)
        {
            Position position = FindPositon(id);
            position.Name = positionName;

            this.PositionRepository.Update(position);
        }

        public void AddPosition(string positionName)
        {
            var random = new Random();
            int testId = random.Next(0, 5000) + random.Next(0, 5000);

            this.PositionRepository.Add(new Position
            {
                Id = testId,
                Name = positionName
            });
        }
    }
}