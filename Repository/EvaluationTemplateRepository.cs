using DB;
using Interfaces.Repository;

namespace Repository
{
    public class EvaluationTemplateRepository : GenericRepository<PositionRepository>, IEvaluationTemplateRepository
    {
        private AppraisalDbContext dbContext;

        public EvaluationTemplateRepository(AppraisalDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddPosition(int id, int positionId)
        {
            this.dbContext.EvaluationsTemplates.Add( new EvaluationTemplate { Id = id, QualificationId = positionId});
        }
    }
}