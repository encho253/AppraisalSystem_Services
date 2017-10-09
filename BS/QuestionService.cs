using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS
{
    public class QuestionService : BaseService, IBaseService, IQuestionService
    {
        public QuestionService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.QuestionRepository = this.UnityManager.Resolve<IQuestionRepository>();
        }

        public IQuestionRepository QuestionRepository { get; set; }

        public void AddQuestion(int id, string questionContent, int competenceId)
        {
            this.QuestionRepository.Add(new Question { Id = id, Content = questionContent, CompetenceId = competenceId });
        }
    }
}