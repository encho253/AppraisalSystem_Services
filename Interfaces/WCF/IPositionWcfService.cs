using System.ServiceModel;

namespace WCF.Interfaces.WCF
{
    [ServiceContract]
    public interface IPositionWcfService
    {
        [OperationContract]
        string[] GetAll();
    }
}