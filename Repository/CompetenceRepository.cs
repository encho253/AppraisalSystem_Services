using DB;
using Interfaces.Repository;
using Repository.Configs;

namespace Repository
{
    public class CompetenceRepository : GenericRepository<Competence>, IGenericRepository<Competence>, ICompetenceRepository
    {
        public CompetenceRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}