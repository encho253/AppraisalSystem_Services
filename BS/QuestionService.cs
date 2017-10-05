using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS
{
    public class QuestionService : BaseService, IBaseService, IQuestionService
    {
        public QuestionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void AddQuestion(int id, string questionContent, int competenceId)
        {
            this.UnitOfWork.QuestionRepository.Add(new Question { Id = id, Content = questionContent, CompetenceId = competenceId });
        }
    }
}