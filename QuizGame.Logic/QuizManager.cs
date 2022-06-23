using QuizGame.Data;

namespace QuizGame.Logic
{
    public class QuizManager : IQuizManager
    {
        private readonly IRepositoryHandler _repositoryHandler;
        public List<Question> InGameQuestions { get; set; }
        public string[] Answers { get; set; }
        public int Highscore { get; set; }
        public bool IsPlaying { get; set; }
        public int AnswerCount { get; set; }
        public int QuestionNumber { get; set; }

#pragma warning disable CS8618
        public QuizManager(IRepositoryHandler repositoryHandler, int questionNumber)
#pragma warning restore CS8618
        {
            _repositoryHandler = repositoryHandler;
            QuestionNumber = questionNumber;
            InGameQuestions = new List<Question>();
        }

        #region Public methods

        public void SetUpAnswer(string answer)
        {
            if (AnswerCount >= InGameQuestions.Count - 1)
            {
                IsPlaying = false;
                return;
            }

            Answers[AnswerCount] = answer;
            AnswerCount++;
        }

        public void CalculateHighscore()
        {
            for (int i = 0; i < InGameQuestions.Count - 1; i++)
            {
                if (CheckAnswer(InGameQuestions[i].CorrectAnswer, Answers[i]))
                {
                    Highscore += 10;
                }
            }
        }

        public void ClearInGameData()
        {
            InGameQuestions = new List<Question>();
#pragma warning disable CS8625
            Answers = null;
#pragma warning restore CS8625
            Highscore = 0;
            AnswerCount = 0;
        }

        public void SetUpInGameData(int questionNumber)
        {
            ClearInGameData();
            InGameQuestions = GetRandomQuestions(questionNumber);
            Answers = new string[InGameQuestions.Count - 1];
            Highscore = 0;
            AnswerCount = 0;
        }

        #endregion

        #region Private methods
        private static bool CheckAnswer(string correctAnswer, string givenAnswer)
        {
            return givenAnswer.Equals(correctAnswer);
        }

        private List<Question> GetRandomQuestions(int questionNumber)
        {
#pragma warning disable IDE0059
            Question randomQuestion = new();
#pragma warning restore IDE0059
            for (int i = 0; i < questionNumber; i++)
            {
                randomQuestion = GetRandomQuestion();

                if (InGameQuestions.Contains(randomQuestion))
                {
                    i--;
                    continue;
                }

                InGameQuestions.Add(randomQuestion);
            }

            return InGameQuestions;
        }

        private Question GetRandomQuestion()
        {
            var random = new Random();
            var existingQuestions = _repositoryHandler.GetExistingQuestions();
            return existingQuestions[random.Next(existingQuestions.Count)];
        }
        #endregion
    }
}