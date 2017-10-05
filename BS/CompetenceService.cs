using BS.Configs;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS
{
    public class CompetenceService : BaseService, IBaseService, ICompetenceService
    {
        public CompetenceService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}