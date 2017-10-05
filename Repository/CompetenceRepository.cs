using DB;
using Interfaces.Repository;

namespace Repository
{
    public class CompetenceRepository : GenericRepository<Competence>, IGenericRepository<Competence>, ICompetenceRepository
    {
        public CompetenceRepository(AppraisalDbContext dbContext) : base(dbContext)
        {
        }
    }
}