using DB;
using Interfaces.Repository;

namespace Repository
{
    public class EvaluationTemplateRepository : GenericRepository<EvaluationTemplate>, IGenericRepository<EvaluationTemplate>, IEvaluationTemplateRepository
    {
        public EvaluationTemplateRepository(AppraisalDbContext dbContext) : base(dbContext)
        {
        }

        public void AddPosition(EvaluationTemplate evaluationTemplate)
        {
            this.DbContext.EvaluationsTemplates.Add(evaluationTemplate);
        }
    }
}