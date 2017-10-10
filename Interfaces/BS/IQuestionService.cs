using DB;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IQuestionService : IBaseService
    {
        void AddQuestion(int id, string questionContent, int competenceId);
        ICollection<Question> GetQuestionsByCompetence(string competence);
    }
}