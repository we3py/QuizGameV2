
using QuizGame.Data.Entities;

namespace QuizGame.Data.Factories
{
    public class HighScoresFactory
    {
        public Highscore GetNew(string userName, int score)
        {
            Highscore newHighscore = new Highscore()
            {
                UserName = userName,
                Score = score
            };
            return newHighscore;
        }
    }
}
