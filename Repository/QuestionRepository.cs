using DB;
using Interfaces.Repository;

namespace Repository
{
    public class QuestionRepository : GenericRepository<Question>, IGenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(AppraisalDbContext dbContext) : base(dbContext)
        {
        }
    }
}