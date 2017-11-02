using DB;
using Interfaces.DTO.Response;
using System.Collections.Generic;
using System.ServiceModel;

namespace Interfaces.WCF
{
    [ServiceContract]
    public interface ICompetenceWcfService
    {
        [OperationContract]
        IEnumerable<string> GetAllCompetencesByName();

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

        [OperationContract]
        IEnumerable<CompetenceDto> GetAllCompetencesByPosition(int positionId);
    }
}