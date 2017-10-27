using BS.Configs;
using Interfaces.BS;
using Interfaces.Repository;
using DB;
using System.Linq;
using System.Collections.Generic;
using System;

namespace BS
{
    public class CompetenceService : BaseService, IBaseService, ICompetenceService
    {
        public CompetenceService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.CompetenceRepository = this.UnityManager.Resolve<ICompetenceRepository>();
            this.PositionRepository = this.UnityManager.Resolve<IPositionRepository>();
        }

        public ICompetenceRepository CompetenceRepository { get; set; }
        public IPositionRepository PositionRepository { get; set; }

        public IEnumerable<string> GetAllCompetencesByName()
        {
            return this.CompetenceRepository.GetAllRecords().Select(x => x.Key).ToArray();
        }

        public Competence GetCompetenceByName(string competence)
        {
            Competence competenceObj = this.CompetenceRepository.GetCompetenceByName(competence);

            return competenceObj;
        }


        public IEnumerable<Competence> GetAllCompetences()
        {
            IEnumerable<Competence> competences = this.CompetenceRepository.GetAllRecords();

            return competences;
        }

        public IEnumerable<Competence> GetAllCompetenceByPosition(string positionName)
        {
            Position position = this.PositionRepository.GetPositionByName(positionName);

            IEnumerable<Competence> competences = this.CompetenceRepository.GetAllCompetencesByPosition(position);

            return competences;
        }

        public IEnumerable<string> GetAllCompetencesNameByPosition(string positionName)
        {
            Position position = this.PositionRepository.GetPositionByName(positionName);

            IEnumerable<Competence> competences = this.CompetenceRepository.GetAllCompetencesByPosition(position);

            IEnumerable<string> competencesName = competences.Select(x => x.Key).ToList();

            return competencesName;
        }

        public void AddCompetence(string competenceName)
        {
            var random = new Random();
            int testId = random.Next(0, 5000) + random.Next(0, 5000);

            this.CompetenceRepository.Add(new Competence
            {
                Id = testId,
                Key = competenceName
            });
        }

        public void UpdateCompetence(int id, string competenceName)
        {
            Competence competence = this.CompetenceRepository.GetFirstOrDefault(id);
            competence.Key = competenceName;

            this.CompetenceRepository.Update(competence);
        }
    }
}