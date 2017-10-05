using System;
using BS.Configs;
using Interfaces.BS;
using Interfaces.Repository;
using DB;

namespace BS
{
    public class CompetenceService : BaseService, IBaseService, ICompetenceService
    {
        public CompetenceService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void AddCompetence(int id, string competenceName)
        {
            this.UnitOfWork.CompetenceRepository.Add(new Competence { Id = id, Key = competenceName });
        }
    }
}