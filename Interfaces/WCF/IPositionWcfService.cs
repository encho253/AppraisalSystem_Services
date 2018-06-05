using DB;
using System.Collections.Generic;
using System.ServiceModel;

namespace WCF.Interfaces.WCF
{
    [ServiceContract]
    public interface IPositionWcfService
    {
        [OperationContract]
        IEnumerable<Position> GetAllPositions();

        [OperationContract]
        Position GetPositionByName(string positionName);

        [OperationContract]
        void UpdatePosition(int id, string positionName);

        [OperationContract]
        void AddPosition(string positionName);
    }
}