using DB;
using Interfaces.DTO.Response;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface ICompetenceService : IBaseService
    {
        IEnumerable<string> GetAllCompetencesByName();
        Competence GetCompetenceByName(string competence);
        IEnumerable<Competence> GetAllCompetences();
        IEnumerable<Competence> GetAllCompetenceByPosition(string positionName);
        void AddCompetence(string competenceName);
        void UpdateCompetence(int id, string competenceName);
        IEnumerable<string> GetAllCompetencesNameByPosition(string positionName);
        IEnumerable<CompetenceDto> GetAllCompetencesByPosition(int positionId);
        Competence GetCompetenceById(int competenceId);
    }
}