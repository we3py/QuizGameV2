using QuizGame.Data.DAL;
using QuizGame.Data.Entities;

namespace QuizGame.Data
{
    public class DataManage
    {


        public void AddQuestion(Question question)
        {
            using (var repository = new Repository<Question>())
            {
                repository.Add(question);
                repository.Save();
            };
        }

        public List<Question> GetExistingQuestions()
        {
            var repository = new Repository<Question>();
            return repository.GetAll().ToList();
        }

        public void AddHighscore(string userName, int score)
        {
            using (var repository = new Repository<Highscore>())
            {
                var highscoreToAdd = new Highscore()
                {
                    UserName = userName,
                    Score = score
                };

                repository.Add(highscoreToAdd);
                repository.Save();
            }
        }

        public List<Highscore> GetHighscores()
        {
            List<Highscore> highscores = new List<Highscore>();

            using (var repository = new Repository<Highscore>())
            {
                highscores = repository.GetAll().ToList();
            };

            return highscores;
        }
    }
}
