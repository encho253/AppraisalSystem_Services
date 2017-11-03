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
            ICollection<Question> questions = this.UnitOfWork.DbContext.Questions
               .Where(c => c.Position.Name == position && c.Competence.Key == competence)
               .ToList();

            return questions;
        }

        public IEnumerable<Question> GetByPosition(string position)
        {
            ICollection<Question> questions = this.UnitOfWork.DbContext.Questions
              .Where(c => c.Position.Name == position)
              .ToList();

            return questions;
        }

        public IEnumerable<Question> GetQuestionsByEvaluationTemplate(int evaluationTemplateId)
        {
            ICollection<Question> questions = this.UnitOfWork.DbContext.EvaluationsTemplates
                .Where(e => e.Id == evaluationTemplateId)
                .SelectMany(q => q.Questions)
                .ToList();

            return questions;
        }
    }
}