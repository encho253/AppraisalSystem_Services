using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using Interfaces.WCF;
using Repository.Configs;
using System.Collections.Generic;

namespace WCF
{
    public class QuestionService : IQuestionWcfService
    {
        public IEnumerable<Question> GetQuestionsByCompetence(string competence)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IQuestionService questionService = dataContainer.Resolve<IQuestionService>();

                IEnumerable<Question> questions = questionService.GetQuestionsByCompetence(competence);

                return questions;
            }
        }

        public IEnumerable<Question> GetAll()
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IQuestionService questionService = dataContainer.Resolve<IQuestionService>();

                IEnumerable<Question> questions = questionService.GetAll();

                return questions;
            }
        }

        public void UpdateQuestion(int questionId, string content)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IQuestionService questionService = dataContainer.Resolve<IQuestionService>();
                IQuestionRepository questionRepo = dataContainer.Resolve<IQuestionRepository>();

                questionService.UpdateQuestion(questionId, content);

                questionRepo.SaveChanges();
            }
        }
    }
}