using DB;
using System.Collections.Generic;

namespace Interfaces.Repository
{
    public interface IQuestionRepository : IGenericRepository<Question>
    {
        ICollection<Question> GetQuestionsByCompetence(string competence);
    }
}