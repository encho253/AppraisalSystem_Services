using DB;
using System.Collections.Generic;
using System.ServiceModel;

namespace Interfaces.WCF
{
    [ServiceContract]
    public interface IEvaluationTemplateWcfService
    {
        [OperationContract]
        IEnumerable<EvaluationTemplate> GetAllTemplates();

        [OperationContract]
        void CreateEvaluationTemplate(int positionId, string templateName, List<int> questionsId);

        [OperationContract]
        void DeleteEvaluationTemplate(int templateId);

        [OperationContract]
        EvaluationTemplate GetEvaluationTemplateById(int evaluationId);
    }
}