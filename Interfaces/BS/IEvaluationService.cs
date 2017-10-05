using System;

namespace Interfaces.BS
{
    public interface IEvaluationService : IBaseService
    {
        void CreateEvaluation(int id, int userId, int evaluationTemplateId);
    }
}