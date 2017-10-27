using DB;
using System.Collections.Generic;
using System.ServiceModel;

namespace Interfaces.WCF
{
    [ServiceContract]
    public interface ICompetenceWcfService
    {      
        [OperationContract]
        IEnumerable<string> GetAllCompetence();

        [OperationContract]
        IEnumerable<Competence> GetAllCompetences();

        [OperationContract]
        IEnumerable<Competence> GetAllCompetenceByPosition(string positionName);

        [OperationContract]
        void AddCompetence(string competenceName);

        [OperationContract]
        void UpdateCompetence(int id, string competenceName);

        [OperationContract]
        IEnumerable<string> GetAllCompetencesNameByPosition(string positionName);
    }
}