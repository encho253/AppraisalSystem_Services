using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.WCF;
using System.Collections.Generic;

namespace WCF
{
    public class QuestionService : IQuestionWcfService
    {
        public ICollection<Question> GetQuestionsByCompetence(string competence)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IQuestionService questionService = dataContainer.Resolve<IQuestionService>();
                ICollection<Question> questions = questionService.GetQuestionsByCompetence(competence);

                return questions;
            }
        }
    }
}