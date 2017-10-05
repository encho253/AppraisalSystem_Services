using BS.Configs;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS
{
    public class QuestionService : BaseService, IBaseService, IQuestionService
    {
        public QuestionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}