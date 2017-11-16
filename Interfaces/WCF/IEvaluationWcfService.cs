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
        void AddEvaluatorToEvaluation(string username, string usernameEvaluator);

        [OperationContract]
        IEnumerable<User> GetAllEvaluatorsForEvaluation(int evaluationId);

        [OperationContract]
        IEnumerable<Evaluation> GetAllEvaluationsForUser(string username);

        [OperationContract]
        Evaluation GetEvaluationById(int evaluationId);
    }
}