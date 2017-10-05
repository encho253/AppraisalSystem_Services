namespace Interfaces.BS
{
    public interface IQuestionService : IBaseService
    {
        void AddQuestion(int id, string questionContent, int competenceId);
    }
}