using DB;
using System.Collections.Generic;
using System.ServiceModel;

namespace Interfaces.WCF
{
    [ServiceContract]
    public interface IEvaluationWcfService
    {
        [OperationContract]
        void CreateEvaluation(int userId, int evaluationTemplateId);

        [OperationContract]
        void AddEvaluatorToEvaluation(Evaluation evaluation, User user);

        [OperationContract]
        IEnumerable<User> GetAllEvaluatorsForEvaluation(int evaluationId);
    }
}