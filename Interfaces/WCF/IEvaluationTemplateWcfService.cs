using DB;
using System.Collections.Generic;
using System.ServiceModel;

namespace Interfaces.WCF
{
    [ServiceContract]
    public interface IEvaluationTemplateWcfService
    {
        [OperationContract]
        IEnumerable<EvaluationTemplate> GetAllTemplates();
    }
}