using DB;

namespace Interfaces.Repository
{
    public interface ICompetenceRepository : IGenericRepository<Competence>
    {
        Competence GetCompetenceByName(string competence);
    }
}