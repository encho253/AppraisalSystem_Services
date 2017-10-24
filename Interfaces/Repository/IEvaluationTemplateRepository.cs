using DB;

namespace Interfaces.Repository
{
    public interface IEvaluationTemplateRepository : IGenericRepository<EvaluationTemplate>
    {
        EvaluationTemplate GetEvaluationTemplateByPosition(string postion);
    }
}