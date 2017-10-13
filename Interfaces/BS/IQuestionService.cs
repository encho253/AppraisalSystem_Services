using DB;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IQuestionService : IBaseService
    {
        void AddQuestion(string questionContent, string competence);
        IEnumerable<Question> GetQuestionsByCompetence(string competence);
        IEnumerable<Question> GetAll();
        void UpdateQuestion(int questionId, string content);
        void Delete(int questionId);
    }
}