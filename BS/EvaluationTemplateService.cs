using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS
{
    public class EvaluationTemplateService : BaseService, IBaseService, IEvaluationTemplateService
    {
        public EvaluationTemplateService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.EvaluationTemplateRepository = this.UnityManager.Resolve<IEvaluationTemplateRepository>();
        }

        public IEvaluationTemplateRepository EvaluationTemplateRepository { get; set; }

        public void CreateEvaluationTemplate(int id, int positionId)
        {
            this.EvaluationTemplateRepository.Add(new EvaluationTemplate { Id = id, QualificationId = id });
        }
    }
}