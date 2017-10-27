using DB;
using Interfaces.Repository;
using Repository.Configs;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class CompetenceRepository : GenericRepository<Competence>, IGenericRepository<Competence>, ICompetenceRepository
    {
        public CompetenceRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Competence GetCompetenceByName(string competence)
        {
             Competence  competenceObj = this.UnitOfWork.DbContext.Competences.FirstOrDefault(x => x.Key == competence);

            return competenceObj;
        }

        public IEnumerable<Competence> GetAllCompetencesByPosition(Position position)
        {
            IEnumerable<Competence> competences = this.UnitOfWork.DbContext.Questions.Where(p => p.PositionId == position.Id).Select(c => c.Competence).ToList();

            return competences;
        }
    }
}