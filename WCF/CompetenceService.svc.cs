using System;
using Interfaces.WCF;
using Interfaces.BS;
using BS.Configs;
using System.Collections.Generic;
using DB;
using Repository.Configs;
using Interfaces.DTO.Response;

namespace WCF
{
    public class CompetenceService : ICompetenceWcfService
    {
        public IEnumerable<string> GetAllCompetencesByName()
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                ICompetenceService competenceService = dataContainer.Resolve<ICompetenceService>();

                return competenceService.GetAllCompetencesByName();
            }
        }

        public IEnumerable<Competence> GetAllCompetences()
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                ICompetenceService competenceService = dataContainer.Resolve<ICompetenceService>();

                return competenceService.GetAllCompetences();
            }
        }

        public IEnumerable<Competence> GetAllCompetenceByPosition(string positionName)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                ICompetenceService competenceService = dataContainer.Resolve<ICompetenceService>();

                return competenceService.GetAllCompetenceByPosition(positionName);
            }
        }

        public void AddCompetence(string competenceName)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                ICompetenceService competenceService = dataContainer.Resolve<ICompetenceService>();

                competenceService.AddCompetence(competenceName);

                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.SaveChanges();
            }
        }

        public void UpdateCompetence(int id, string competenceName)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                ICompetenceService competenceService = dataContainer.Resolve<ICompetenceService>();

                competenceService.UpdateCompetence(id, competenceName);

                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.SaveChanges();
            }
        }

        public IEnumerable<string> GetAllCompetencesNameByPosition(string positionName)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                ICompetenceService competenceService = dataContainer.Resolve<ICompetenceService>();

                return competenceService.GetAllCompetencesNameByPosition(positionName);
            }
        }

        public IEnumerable<CompetenceDto> GetAllCompetencesByPosition(int positionId)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                ICompetenceService competenceService = dataContainer.Resolve<ICompetenceService>();

                return competenceService.GetAllCompetencesByPosition(positionId);
            }
        }
    }
}