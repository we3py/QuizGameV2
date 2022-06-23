namespace QuizGame.Data
{
    public class RepositoryHandler : IRepositoryHandler
    {
#pragma warning disable IDE0052
        private readonly QuizGameContext _context;
#pragma warning restore IDE0052

#pragma warning disable CS8618
        public RepositoryHandler()
#pragma warning restore CS8618
        { }

        public RepositoryHandler(QuizGameContext context)
        {
            _context = context;
        }

        public void AddQuestion(Question question)
        {
            using var repository = new Repository<Question>();
            repository.Add(question);
            repository.Save();
        }

        public List<Question> GetExistingQuestions()
        {
            var repository = new Repository<Question>();
            return repository.GetAll().ToList();
        }

        public void AddHighscore(string userName, int score)
        {
            using var repository = new Repository<Highscore>();
            var highscoreToAdd = new Highscore()
            {
                UserName = userName,
                Score = score
            };

            repository.Add(highscoreToAdd);
            repository.Save();
        }

        public List<Highscore> GetHighscores()
        {
            List<Highscore> highscores = new();

            using (var repository = new Repository<Highscore>())
            {
                highscores = repository.GetAll().ToList();
            }

            return highscores;
        }
    }
 }
