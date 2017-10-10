using System.ServiceModel;

namespace Interfaces.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICompetenceService" in both code and config file together.
    [ServiceContract]
    public interface ICompetenceWcfService
    {
        [OperationContract]
        void AddCompetence(int id, string competenceName);

        [OperationContract]
        string[] GetAllCompetence();
    }
}