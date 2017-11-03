using DB;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IEvaluationTemplateService : IBaseService
    {
        void CreateEvaluationTemplate(int id, int positionId);
        EvaluationTemplate GetEvaluationTemplateByPosition(string position);
        IEnumerable<EvaluationTemplate> GetAllTemplates();
        void CreateEvaluationTemplate(int positionId, string templateName);
    }
}