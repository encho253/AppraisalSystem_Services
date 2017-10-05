using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using System;

namespace BS
{
    public class EvaluationService : BaseService, IBaseService, IEvaluationService
    {
        public EvaluationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void CreateEvaluation(int id, int userId, int evaluationTemplateId)
        {
            this.UnitOfWork.EvaluationRepository.Add(new Evaluation { Id = id, UserId = userId, EvaluationTemplateId = evaluationTemplateId });
        }
    }
}