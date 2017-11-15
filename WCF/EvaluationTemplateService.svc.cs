using System.Collections.Generic;
using DB;
using Interfaces.WCF;
using BS.Configs;
using Interfaces.BS;
using Repository.Configs;

namespace WCF
{
    public class EvaluationTemplateService : IEvaluationTemplateWcfService
    {      
        public IEnumerable<EvaluationTemplate> GetAllTemplates()
        {
            using (UnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IEvaluationTemplateService evaluationTemplate = dataContainer.Resolve<IEvaluationTemplateService>();

                IEnumerable<EvaluationTemplate> evaluationTemplates = evaluationTemplate.GetAllTemplates();

                return evaluationTemplates;
            }
        }

        public void CreateEvaluationTemplate(int positionId, string templateName, List<int> questionsId)
        {
            using (UnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IEvaluationTemplateService evaluationTemplate = dataContainer.Resolve<IEvaluationTemplateService>();

                evaluationTemplate.CreateEvaluationTemplate(positionId, templateName, questionsId);

                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.SaveChanges();
            }
        }
    }
}