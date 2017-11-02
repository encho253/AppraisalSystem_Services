using DB;
using Interfaces.WCF;
using BS.Configs;
using Interfaces.BS;
using Repository.Configs;
using System.Collections.Generic;

namespace WCF
{
    public class EvaluationService : IEvaluationWcfService
    {
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

        public IEnumerable<User> GetAllEvaluatorsForEvaluation(string username)
        {
            using (UnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IEvaluationService evaluationService = dataContainer.Resolve<IEvaluationService>();

                IEnumerable<User> users = evaluationService.GetAllEvaluatorsForEvaluation(username);

                return users;
            }
        }

        public void AddEvaluatorToEvaluation(string username, string usernameEvaluator)
        {
            using (UnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IEvaluationService evaluationService = dataContainer.Resolve<IEvaluationService>();

                evaluationService.AddEvaluatorToEvaluation(username, usernameEvaluator);

                var unitofwork = new UnitOfWork();

                unitofwork.SaveChanges();
            }
        }

        public IEnumerable<Evaluation> GetUserEvaluation(string username)
        {
            using (UnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IEvaluationService evaluationService = dataContainer.Resolve<IEvaluationService>();

                return evaluationService.GetAllEvaluationsForUser(username);
            }
        }

        public IEnumerable<Evaluation> GetAllEvaluationsForUser(string username)
        {
            using (UnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IEvaluationService evaluationService = dataContainer.Resolve<IEvaluationService>();

                return evaluationService.GetAllEvaluationsForUser(username);
            }
        }
    }
}