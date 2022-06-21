using QuizGame.Data.Entities;

namespace QuizGame.Data
{
    public interface IRepositoryHandler
    {
        void AddHighscore(string userName, int score);
        void AddQuestion(Question question);
        List<Question> GetExistingQuestions();
        List<Highscore> GetHighscores();
    }
}