﻿using DB;
using Interfaces.Repository;
using Repository.Configs;

namespace Repository
{
    public class QuestionRepository : GenericRepository<Question>, IGenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}