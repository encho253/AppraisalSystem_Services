using BS.Configs;
using Interfaces.BS;
using Interfaces.Repository;
using DB;
using System.Linq;
using System.Collections.Generic;
using System;
using Interfaces.DTO.Response;

namespace BS
{
    public class CompetenceService : BaseService, IBaseService, ICompetenceService
    {
        public CompetenceService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.CompetenceRepository = this.UnityManager.Resolve<ICompetenceRepository>();
            this.PositionRepository = this.UnityManager.Resolve<IPositionRepository>();
            this.QuestionService = this.UnityManager.Resolve<IQuestionService>();
        }

        public ICompetenceRepository CompetenceRepository { get; set; }
        public IPositionRepository PositionRepository { get; set; }
        public IQuestionService QuestionService { get; set; }

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

        public IEnumerable<CompetenceDto> GetAllCompetencesByPosition(int positionId)
        {
            List<CompetenceDto> listCompetenceDto = new List<CompetenceDto>();
            IEnumerable<Competence> competences = this.CompetenceRepository.GetAllRecords();

            Position position = this.PositionRepository.GetFirstOrDefault(positionId);

            foreach (var competence in competences)
            {
                listCompetenceDto.Add(new CompetenceDto(competence));
                IEnumerable<Question> questions = this.QuestionService.GetQuestionByPositionAndCompetence(position.Name, competence.Key);
                listCompetenceDto.Last().Questions = questions;

                if (questions != null)
                {
                    listCompetenceDto.Last().QuestionsCount = questions.Count();
                }
                else
                {
                    listCompetenceDto.Last().QuestionsCount = 0;
                }  
            }

            return listCompetenceDto;
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

        public Competence GetCompetenceById(int competenceId)
        {
            Competence competence = this.CompetenceRepository.GetFirstOrDefault(competenceId);

            return competence;
        }
    }
}