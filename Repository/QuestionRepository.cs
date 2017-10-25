using DB;
using Interfaces.Repository;
using Repository.Configs;
using System.Collections.Generic;
using System.Linq;
using System;

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

        public IEnumerable<Question> GetQuestionByPositionAndCompetence(string position, string competence)
        {
            ICollection<Question> questions = this.UnitOfWork.DbContext.EvaluationsTemplates
               .Where(c => c.Position.Name == position)
               .SelectMany(q => q.Questions)
               .Where(x => x.Competence.Key == competence)
               .ToList();

            return questions;
        }
    }
}