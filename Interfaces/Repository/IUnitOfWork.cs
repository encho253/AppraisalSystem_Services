namespace Interfaces.Repository
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IEvaluationTemplateRepository EvaluationTemplateRepository { get; }
        IPositionRepository PositionRepository { get; }
        ICompetenceRepository CompetenceRepository { get; }
        IQuestionRepository QuestionRepository { get; }
        IEvaluationRepository EvaluationRepository { get; }

        void SaveChanges();
    }
}