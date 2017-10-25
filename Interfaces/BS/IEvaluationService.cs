using DB;
using Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IEvaluationService : IBaseService
    {
        IEvaluationRepository EvaluationRepository { get; set; }

        void CreateEvaluation(int userId, int evaluationTemplateId);
        void AddEvaluatorToEvaluation(Evaluation evaluation, User user);
        IEnumerable<User> GetAllEvaluatorsForEvaluation(string username);
    }
}