using DB;
using System.Collections.Generic;

namespace Interfaces.Repository
{
    public interface IEvaluationRepository : IGenericRepository<Evaluation>
    {
        IEnumerable<User> GetAllEvaluatorsForEvaluation(Evaluation evaluation);
        Evaluation GetUserEvaluation(string username);
        void AddEvaluatorToEvaluation(Evaluation evaluation, User evaluator);
        IEnumerable<Evaluation> GetAllEvaluationsForUser(string username);
    }
}