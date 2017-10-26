using DB;
using System.Collections.Generic;

namespace Interfaces.Repository
{
    public interface IEvaluationRepository : IGenericRepository<Evaluation>
    {
        //void AddEvaluatorToEvaluation(string user, string evaluator);
        IEnumerable<User> GetAllEvaluatorsForEvaluation(Evaluation evaluation);
        Evaluation GetUserEvaluation(string username);
    }
}