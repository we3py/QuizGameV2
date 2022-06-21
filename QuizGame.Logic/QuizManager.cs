using QuizGame.Data;

namespace QuizGame.Logic
{
    public class QuizManager : IQuizManager
    {
        private IRepositoryHandler _repositoryHandler;
        public Question[] InGameQuestions { get; set; }
        public string[] Answers { get; set; }
        public int Highscore { get; set; }

        public QuizManager(IRepositoryHandler repositoryHandler, int questionNumber)
        {
            _repositoryHandler = repositoryHandler;
            SetUpInGameData(questionNumber);         
        }

        #region Public methods

        public void SetUpAnswer(int answerIndex, string answer)
        {
            Answers[answerIndex] = answer;
        }

        public void CalculateHighscore()
        {
            for (int i = 0; i < InGameQuestions.Length; i++)
            {
                if (CheckAnswer(InGameQuestions[i].CorrectAnswer, Answers[i]))
                {
                    Highscore += 10;
                }
            }
        }

        public void ClearInGameData()
        {
            InGameQuestions = null;
            Answers = null;
            Highscore = 0;
        }

        public void SetUpInGameData(int questionNumber)
        {
            InGameQuestions = GetRandomQuestions(questionNumber);
            Answers = new string[questionNumber];
        }

        #endregion

        #region Private methods
        private bool CheckAnswer(string correctAnswer, string givenAnswer)
        {
            if (givenAnswer.Equals(correctAnswer)) { return true; }

            return false;
        }

        private Question[] GetRandomQuestions(int questionNumber)
        {
            var allQuestions = _repositoryHandler.GetExistingQuestions();
            List<Question> questionsToPlayOn = new List<Question>();
            var indexOfQuestion = GetRandomNumber(allQuestions.Count - 1);
            questionsToPlayOn.Add(allQuestions[indexOfQuestion]);

            for (int i = 0; i < questionNumber; i++)
            {
                indexOfQuestion = GetRandomNumberUnreapetable(indexOfQuestion, questionNumber);
                questionsToPlayOn.Add(allQuestions[indexOfQuestion]);
            }

            return questionsToPlayOn.ToArray();
        }

        private int GetRandomNumberUnreapetable(int previousNumber, int range)
        {
            Random random = new Random();
            var randomNumber = random.Next(range);

            if (randomNumber == previousNumber)
            {
                GetRandomNumberUnreapetable(previousNumber, range);
            }

            return randomNumber;
        }

        private int GetRandomNumber(int range)
        {
            Random random = new Random();
            var randomNumber = random.Next(range);

            return randomNumber;
        }
        #endregion
    }
}