using DB;
using System.Collections.Generic;
using System.ServiceModel;

namespace WCF.Interfaces.WCF
{
    [ServiceContract]
    public interface IPositionWcfService
    {
        //[OperationContract]
        //IEnumerable<string> GetAllPositionsByName();

        [OperationContract]
        IEnumerable<Position> GetAllPositions();

        [OperationContract]
        void UpdatePosition(int id, string positionName);

        [OperationContract]
        void AddPosition(string positionName);
    }
}