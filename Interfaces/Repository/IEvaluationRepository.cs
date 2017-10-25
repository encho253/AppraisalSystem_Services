using DB;
using System.Collections.Generic;

namespace Interfaces.Repository
{
    public interface IEvaluationRepository : IGenericRepository<Evaluation>
    {
        void AddEvaluatorToEvaluation(Evaluation evaluation, User user);
        IEnumerable<User> GetAllEvaluatorsForEvaluation(Evaluation evaluation);
    }
}