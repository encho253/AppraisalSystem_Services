using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using System.Collections.Generic;

namespace BS
{
    public class PositionService : BaseService, IBaseService, IPositionService
    {
        private IUnitOfWork unitOfWork;

        public PositionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Position> GetAll()
        {
            IEnumerable<Position> positions = this.unitOfWork.PositionRepository.GetAllRecords();

            return positions;
        }
    }
}