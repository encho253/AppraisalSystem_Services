using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using System.Collections.Generic;

namespace BS
{
    public class PositionService : BaseService, IBaseService, IPositionService
    {
        public PositionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Position> GetAll()
        {
            IEnumerable<Position> positions = this.UnitOfWork.PositionRepository.GetAllRecords();

            return positions;
        }

        public Position FindPositon(int id)
        {
            return this.UnitOfWork.PositionRepository.GetFirstOrDefault(id);
        }
    }
}