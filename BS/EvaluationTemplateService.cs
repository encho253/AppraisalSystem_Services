using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS
{
    public class EvaluationTemplateService : BaseService, IBaseService, IEvaluationTemplateService
    {
        public EvaluationTemplateService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void AddPosition(Position position)
        {
        }
    }
}