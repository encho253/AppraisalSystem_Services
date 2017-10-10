using BS.Configs;
using Interfaces.BS;
using Interfaces.Repository;
using DB;
using System.Linq;

namespace BS
{
    public class CompetenceService : BaseService, IBaseService, ICompetenceService
    {
        public CompetenceService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.CompetenceRepository = this.UnityManager.Resolve<ICompetenceRepository>();
        }

        public ICompetenceRepository CompetenceRepository { get; set; }

        public void AddCompetence(int id, string competenceName)
        {
            this.CompetenceRepository.Add(new Competence { Id = id, Key = competenceName });
        }

        public string[] GetAllCompetence()
        {
            return this.CompetenceRepository.GetAllRecords().Select(x => x.Key).ToArray();
        }
    }
}