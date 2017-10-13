using DB;
using Interfaces.Repository;
using Repository.Configs;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class QuestionRepository : GenericRepository<Question>, IGenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public ICollection<Question> GetQuestionsByCompetence(string competence)
        {
            ICollection<Question> questions = this.UnitOfWork.DbContext.Questions.Where(x => x.Competence.Key == competence).ToArray();

            return questions;
        }
    }
}