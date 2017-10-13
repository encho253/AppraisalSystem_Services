using DB;
using System.Collections.Generic;
using System.ServiceModel;

namespace Interfaces.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQuestionService" in both code and config file together.
    [ServiceContract]
    public interface IQuestionWcfService
    {
        [OperationContract]
        IEnumerable<Question> GetQuestionsByCompetence(string competence);

        [OperationContract]
        void UpdateQuestion(int questionId, string content);

        [OperationContract]
        IEnumerable<Question> GetAll();

        [OperationContract]
        void AddQuestion(string questionContent, string competence);
    }
}