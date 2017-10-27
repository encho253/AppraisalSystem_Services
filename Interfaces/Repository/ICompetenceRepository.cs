using DB;
using System.Collections.Generic;

namespace Interfaces.Repository
{
    public interface ICompetenceRepository : IGenericRepository<Competence>
    {
        Competence GetCompetenceByName(string competence);
        IEnumerable<Competence> GetAllCompetencesByPosition(Position position);
    }
}