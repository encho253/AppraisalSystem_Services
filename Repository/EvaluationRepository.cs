﻿using DB;
using Interfaces.Repository;
using Repository.Configs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class EvaluationRepository : GenericRepository<Evaluation>, IGenericRepository<Evaluation>, IEvaluationRepository
    {
        public EvaluationRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void AddEvaluatorToEvaluation(Evaluation evaluation, User evaluator)
        {
            evaluation.Users.Add(evaluator);
        }

        public IEnumerable<Evaluation> GetAllEvaluationsForUser(string username)
        {
            IEnumerable<Evaluation> users = this.UnitOfWork.DbContext.Evaluations
               .Where(x => x.User.Email == username)
               .ToList();

            return users;
        }

        public IEnumerable<User> GetAllEvaluatorsForEvaluation(Evaluation evaluation)
        {
            IEnumerable<User> users = this.UnitOfWork.DbContext.Evaluations
                .Where(x => x.Id == evaluation.Id)
                .SelectMany(q => q.Users)
                .ToList();

            return users;
        }

        public Evaluation GetUserEvaluation(string username)
        {
            Evaluation evaluation = this.UnitOfWork.DbContext.Evaluations.FirstOrDefault(x => x.User.Email == username);

            return evaluation;
        }
    }
}