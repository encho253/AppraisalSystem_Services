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
        }

        public IEvaluationRepository EvaluationRepository { get; set; }

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

        public void AddEvaluatorToEvaluation(Evaluation evaluation, User user)
        {
            this.EvaluationRepository.AddEvaluatorToEvaluation(evaluation, user);
        }

        public IEnumerable<User> GetAllEvaluatorsForEvaluation(int evaluationId)
        {
            Evaluation evaluation = this.EvaluationRepository.GetFirstOrDefault(evaluationId);

            IEnumerable<User> users = this.EvaluationRepository.GetAllEvaluatorsForEvaluation(evaluation);

            return users;
        }
    }
}