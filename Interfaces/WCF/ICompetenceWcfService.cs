using System.ServiceModel;

namespace Interfaces.WCF
{
    [ServiceContract]
    public interface ICompetenceWcfService
    {
        [OperationContract]
        void AddCompetence(int id, string competenceName);

        [OperationContract]
        string[] GetAllCompetence();
    }
}