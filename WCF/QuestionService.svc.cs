﻿using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using Interfaces.WCF;
using System.Collections.Generic;

namespace WCF
{
    public class QuestionService : IQuestionWcfService
    {
        public IEnumerable<Question> GetQuestionsByCompetence(string competence)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IQuestionService questionService = dataContainer.Resolve<IQuestionService>();

                IEnumerable<Question> questions = questionService.GetQuestionsByCompetence(competence);

                return questions;
            }
        }

        public IEnumerable<Question> GetQuestionByPositionAndCompetence(string position, string competence)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IQuestionService questionService = dataContainer.Resolve<IQuestionService>();
                return questionService.GetQuestionByPositionAndCompetence(position, competence);
            }
        }

        public IEnumerable<Question> GetAll()
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IQuestionService questionService = dataContainer.Resolve<IQuestionService>();
                IEnumerable<Question> questions = questionService.GetAll();

                return questions;
            }
        }

        public void UpdateQuestion(int questionId, string content)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IQuestionService questionService = dataContainer.Resolve<IQuestionService>();
                IQuestionRepository questionRepo = dataContainer.Resolve<IQuestionRepository>();

                questionService.UpdateQuestion(questionId, content);

                questionRepo.SaveChanges();
            }
        }

        public void AddQuestion(string questionContent, string position, int competenceId)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IQuestionService questionService = dataContainer.Resolve<IQuestionService>();
                IQuestionRepository questionRepo = dataContainer.Resolve<IQuestionRepository>();

                questionService.AddQuestion(questionContent, position, competenceId);

                questionRepo.SaveChanges();
            }
        }

        public void Delete(int questionId)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IQuestionService questionService = dataContainer.Resolve<IQuestionService>();
                IQuestionRepository questionRepo = dataContainer.Resolve<IQuestionRepository>();

                questionService.Delete(questionId);

                questionRepo.SaveChanges();
            }
        }

        public IEnumerable<Question> GetByPosition(string position)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IQuestionService questionService = dataContainer.Resolve<IQuestionService>();
                IEnumerable<Question> questions = questionService.GetByPosition(position);

                return questions;
            }
        }

        public IEnumerable<Question> GetAllQuestionsByEvaluationTemplate(int evaluationTemplateId)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IQuestionService questionService = dataContainer.Resolve<IQuestionService>();
                IEnumerable<Question> questions = questionService.GetAllQuestionsByEvaluationTemplate(evaluationTemplateId);

                return questions;
            }
        }
    }
}