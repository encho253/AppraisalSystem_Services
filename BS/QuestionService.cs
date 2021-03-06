﻿using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace BS
{
    public class QuestionService : BaseService, IBaseService, IQuestionService
    {
        public QuestionService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.QuestionRepository = this.UnityManager.Resolve<IQuestionRepository>();
            this.PositionRepository = this.UnityManager.Resolve<IPositionRepository>();
            this.EvaluationTemplate = this.UnityManager.Resolve<IEvaluationTemplateRepository>();
        }

        public IPositionRepository PositionRepository { get; set; }
        public IQuestionRepository QuestionRepository { get; set; }
        public IEvaluationTemplateRepository EvaluationTemplate { get; set; }

        public void AddQuestion(string questionContent, string position, int competenceId)
        {
            EvaluationTemplate evaluationTemplate = this.EvaluationTemplate.GetEvaluationTemplateByPosition(position);
            Position positionObj = this.PositionRepository.GetPositionByName(position);

            ICollection<EvaluationTemplate> evalTemplate = new List<EvaluationTemplate>();
            evalTemplate.Add(evaluationTemplate);

            questionContent = questionContent.Trim().ToString();
            var random = new Random();
            int testId = random.Next(0, 5000) + random.Next(0, 5000);

            this.QuestionRepository.Add(new Question
            {
                Id = testId,
                Content = questionContent,
                CompetenceId = competenceId,
                EvaluationTemplates = evalTemplate,
                PositionId = positionObj.Id
            });
        }

        public IEnumerable<Question> GetQuestionsByCompetence(string competence)
        {
            IEnumerable<Question> questions = null;

            if (competence == "Get all")
            {
                questions = GetAll();

                return questions;
            }

            questions = this.QuestionRepository.GetQuestionsByCompetence(competence);

            return questions;
        }

        public IEnumerable<Question> GetQuestionByPositionAndCompetence(string position, string competence)
        {
            return this.QuestionRepository.GetQuestionByPositionAndCompetence(position, competence);
        }

        public IEnumerable<Question> GetAll()
        {
            return this.QuestionRepository.GetAllRecords();
        }

        public void UpdateQuestion(int questionId, string content)
        {
            Question updatedQuestion = this.QuestionRepository.GetFirstOrDefault(questionId);
            updatedQuestion.Content = content;

            this.QuestionRepository.Update(updatedQuestion);
        }

        public void Delete(int questionId)
        {
            Question question = this.QuestionRepository.GetFirstOrDefault(questionId);

            this.QuestionRepository.Delete(question);
        }

        public IEnumerable<Question> GetByPosition(string position)
        {
            return this.QuestionRepository.GetByPosition(position);
        }

        public Question GetById(int id)
        {
            return this.QuestionRepository.GetFirstOrDefault(id);        
        }

        public IEnumerable<Question> GetAllQuestionsByEvaluationTemplate(int evaluationTemplateId)
        {
            IEnumerable<Question> questions = this.QuestionRepository.GetQuestionsByEvaluationTemplate(evaluationTemplateId);

            return questions;
        }
    }
}