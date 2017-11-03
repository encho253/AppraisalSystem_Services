using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using System;
using System.Collections.Generic;

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

        public EvaluationTemplate GetEvaluationTemplateByPosition(string position)
        {
            return this.EvaluationTemplateRepository.GetEvaluationTemplateByPosition(position);
        }

        public IEnumerable<EvaluationTemplate> GetAllTemplates()
        {
            return this.EvaluationTemplateRepository.GetAllRecords();
        }

        public void CreateEvaluationTemplate(int positionId, string templateName)
        {
            var random = new Random();
            int testId = random.Next(0, 5000) + random.Next(0, 5000);

            this.EvaluationTemplateRepository.Add(new EvaluationTemplate
            {
                Id = testId,
                QualificationId = positionId,
                Name = templateName
            });
        }
    }
}