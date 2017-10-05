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

        public void CreateEvaluationTemplate(int id, int positionId)
        {
            this.UnitOfWork.EvaluationTemplateRepository.Add(new EvaluationTemplate { Id = id, QualificationId = id });
        }
    }
}