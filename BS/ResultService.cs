using BS.Configs;
using Interfaces.BS;
using Interfaces.Repository;
using System.Linq;

namespace BS
{
    public class ResultService : BaseService, IBaseService, IResultService
    {
        public ResultService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.ResultRepository = this.UnityManager.Resolve<IResultRepository>();
        }

        public IResultRepository ResultRepository { get; private set; }

        public void GetAllResults()
        {
            var p = this.ResultRepository.GetAllRecords();

            //var c = p.Select(x => x.Evaluation.User.FirstName && x.);
        }
    }
}