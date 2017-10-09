using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using System;

namespace BS
{
    public class EvaluationService : BaseService, IBaseService, IEvaluationService
    {
        public EvaluationService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.EvaluationRepository = this.UnityManager.Resolve<IEvaluationRepository>();
        }

        public IEvaluationRepository EvaluationRepository { get; set; }

        public void CreateEvaluation(int id, int userId, int evaluationTemplateId)
        {
            this.EvaluationRepository.Add(new Evaluation { Id = id, UserId = userId, EvaluationTemplateId = evaluationTemplateId });
        }
    }
}