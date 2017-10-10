using System;
using Interfaces.WCF;
using Interfaces.BS;
using BS.Configs;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CompetenceService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CompetenceService.svc or CompetenceService.svc.cs at the Solution Explorer and start debugging.
    public class CompetenceService : ICompetenceWcfService
    {
        public void AddCompetence(int id, string competenceName)
        {
            throw new NotImplementedException();
        }

        public string[] GetAllCompetence()
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                ICompetenceService competenceService = dataContainer.Resolve<ICompetenceService>();

                return competenceService.GetAllCompetence();
            }
        }
    }
}
