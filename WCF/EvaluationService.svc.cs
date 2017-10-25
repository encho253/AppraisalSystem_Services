using DB;
using Interfaces.WCF;
using BS.Configs;
using Interfaces.BS;
using Repository.Configs;
using System;
using System.Collections.Generic;

namespace WCF
{
    public class EvaluationService : IEvaluationWcfService
    {
        public void AddEvaluatorToEvaluation(Evaluation evaluation, User user)
        {
            
        }

        public void CreateEvaluation(int userId, int evaluationTemplateId)
        {
            using (UnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IEvaluationService eval = dataContainer.Resolve<IEvaluationService>();

                eval.CreateEvaluation(userId, evaluationTemplateId);

                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.SaveChanges();
            }
        }

        public IEnumerable<User> GetAllEvaluatorsForEvaluation(int evaluationId)
        {
            using (UnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IEvaluationService evaluationService = dataContainer.Resolve<IEvaluationService>();

                IEnumerable<User> users = evaluationService.GetAllEvaluatorsForEvaluation(evaluationId);

                return users;
            }
        }
    }
}