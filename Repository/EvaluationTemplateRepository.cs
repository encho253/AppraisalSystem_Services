using DB;
using Interfaces.Repository;
using Repository.Configs;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class EvaluationTemplateRepository : GenericRepository<EvaluationTemplate>, IGenericRepository<EvaluationTemplate>, IEvaluationTemplateRepository
    {
        public EvaluationTemplateRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void AddPosition(EvaluationTemplate evaluationTemplate)
        {
            this.UnitOfWork.DbContext.EvaluationsTemplates.Add(evaluationTemplate);
        }

        public EvaluationTemplate GetEvaluationTemplateByPosition(string postion)
        {
            return this.UnitOfWork.DbContext.EvaluationsTemplates.FirstOrDefault(x => x.Position.Name == postion);
        }
    }
}