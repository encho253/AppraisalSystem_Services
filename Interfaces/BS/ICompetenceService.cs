namespace Interfaces.BS
{
    public interface ICompetenceService : IBaseService
    {
        void AddCompetence(int id, string competenceName);
    }
}