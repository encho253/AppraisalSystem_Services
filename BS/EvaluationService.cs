﻿using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace BS
{
    public class EvaluationService : BaseService, IBaseService, IEvaluationService
    {
        public EvaluationService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.EvaluationRepository = this.UnityManager.Resolve<IEvaluationRepository>();
            this.userService = this.UnityManager.Resolve<IUserService>();
        }

        public IEvaluationRepository EvaluationRepository { get; set; }
        public IUserService userService { get; set; }

        public void CreateEvaluation(int userId, int evaluationTemplateId)
        {
            var random = new Random();
            int testId = random.Next(0, 5000) + random.Next(0, 5000);

            this.EvaluationRepository.Add(new Evaluation
            {
                Id = testId,
                UserId = userId,
                EvaluationTemplateId = evaluationTemplateId
            });
        }

        public void AddEvaluatorToEvaluation(string username, string usernameEvaluator)
        {
            Evaluation evaluation = GetEvaluation(username);
            User evaluator = this.userService.SearchByUserName(usernameEvaluator);

            this.EvaluationRepository.AddEvaluatorToEvaluation(evaluation, evaluator);
        }

        public IEnumerable<User> GetAllEvaluatorsForEvaluation(int evaluationId)
        {
            Evaluation evaluation = this.EvaluationRepository.GetFirstOrDefault(evaluationId);
            IEnumerable<User> users = new List<User>();

            if (evaluation != null)
            {
                users = this.EvaluationRepository.GetAllEvaluatorsForEvaluation(evaluation);

                return users;
            }

            return users;
        }

        public Evaluation GetEvaluation(string username)
        {
            Evaluation evaluation = this.EvaluationRepository.GetUserEvaluation(username);

            return evaluation;
        }

        public Evaluation GetEvaluationById(int evaluationId)
        {
            return this.EvaluationRepository.GetFirstOrDefault(evaluationId);
        }

        public IEnumerable<Evaluation> GetAllEvaluationsForUser(string username)
        {
            IEnumerable<Evaluation> evaluations = this.EvaluationRepository.GetAllEvaluationsForUser(username);


            return evaluations;
        }
    }
}