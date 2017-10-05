namespace Interfaces.BS
{
    public interface IEvaluationTemplateService : IBaseService
    {
        void CreateEvaluationTemplate(int id, int positionId);
    }
}