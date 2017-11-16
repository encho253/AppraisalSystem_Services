using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace BS
{
    public class EvaluationTemplateService : BaseService, IBaseService, IEvaluationTemplateService
    {
        public EvaluationTemplateService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.EvaluationTemplateRepository = this.UnityManager.Resolve<IEvaluationTemplateRepository>();
            this.QuestionService = this.UnityManager.Resolve<IQuestionService>();
        }

        public IEvaluationTemplateRepository EvaluationTemplateRepository { get; set; }
        public IQuestionService QuestionService { get; set; }

        public void CreateEvaluationTemplate(int id, int positionId)
        {
            this.EvaluationTemplateRepository.Add(new EvaluationTemplate { Id = id, QualificationId = id });
        }

        public EvaluationTemplate GetEvaluationTemplateByPosition(string position)
        {
            return this.EvaluationTemplateRepository.GetEvaluationTemplateByPosition(position);
        }

        public EvaluationTemplate GetEvaluationTemplateById(int evaluationId)
        {
            return this.EvaluationTemplateRepository.GetFirstOrDefault(evaluationId);
        }

        public IEnumerable<EvaluationTemplate> GetAllTemplates()
        {
            return this.EvaluationTemplateRepository.GetAllRecords();
        }

        public void CreateEvaluationTemplate(int positionId, string templateName, List<int> questionsId)
        {
            var random = new Random();
            int testId = random.Next(0, 5000) + random.Next(0, 5000);

            ICollection<Question> questions = new List<Question>();

            foreach (var questionId in questionsId)
            {
                Question question = this.QuestionService.GetById(questionId);
                questions.Add(question);
            }

            this.EvaluationTemplateRepository.Add(new EvaluationTemplate
            {
                Id = testId,
                QualificationId = positionId,
                Name = templateName,
                Questions = questions
            });
        }

        public void DeleteEvaluationTemplate(int templateId)
        {
            EvaluationTemplate evalTemplate = this.EvaluationTemplateRepository.GetFirstOrDefault(templateId);

            this.EvaluationTemplateRepository.Delete(evalTemplate);
        }
    }
}