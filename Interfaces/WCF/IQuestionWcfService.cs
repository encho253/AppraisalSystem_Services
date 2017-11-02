using DB;
using System.Collections.Generic;
using System.ServiceModel;

namespace Interfaces.WCF
{
    [ServiceContract]
    public interface IQuestionWcfService
    {
        [OperationContract]
        IEnumerable<Question> GetQuestionsByCompetence(string competence);

        [OperationContract]
        IEnumerable<Question> GetQuestionByPositionAndCompetence(string position, string competence);

        [OperationContract]
        void UpdateQuestion(int questionId, string content);

        [OperationContract]
        IEnumerable<Question> GetAll();

        [OperationContract]
        void AddQuestion(string questionContent, string position, int competenceId);

        [OperationContract]
        void Delete(int questionId);

        [OperationContract]
        IEnumerable<Question> GetByPosition(string position);
    }
}