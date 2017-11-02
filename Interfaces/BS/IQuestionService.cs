using DB;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IQuestionService : IBaseService
    {
        void AddQuestion(string questionContent, string position, int competenceId);
        IEnumerable<Question> GetQuestionsByCompetence(string competence);
        IEnumerable<Question> GetQuestionByPositionAndCompetence(string position, string competence);
        IEnumerable<Question> GetAll();
        void UpdateQuestion(int questionId, string content);
        void Delete(int questionId);
        IEnumerable<Question> GetByPosition(string position);
    }
}