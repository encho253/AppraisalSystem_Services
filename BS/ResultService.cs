using BS.Configs;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS
{
    public class ResultService : BaseService, IBaseService, IResultService
    {
        public ResultService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}