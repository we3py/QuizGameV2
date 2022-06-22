using QuizGame.Data;

namespace QuizGame.Logic
{
    public class QuizManager : IQuizManager
    {
        private IRepositoryHandler _repositoryHandler;
        public Question[] InGameQuestions { get; set; }
        public string[] Answers { get; set; }
        public int Highscore { get; set; }
        public bool IsPlaying { get; set; }
        public int AnswerCount { get; set; }
        public int QuestionNumber { get; set; }

        public QuizManager(IRepositoryHandler repositoryHandler, int questionNumber)
        {
            _repositoryHandler = repositoryHandler;
            QuestionNumber = questionNumber;
            SetUpInGameData(QuestionNumber);         
        }

        #region Public methods

        public void SetUpAnswer(string answer)
        {
            if (AnswerCount >= InGameQuestions.Length - 1) 
            { 
                IsPlaying = false;
                return;
            }

            Answers[AnswerCount] = answer;
            AnswerCount++;
        }

        public void CalculateHighscore()
        {
            for (int i = 0; i < InGameQuestions.Length - 1; i++)
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
            AnswerCount = 0;
        }

        public void SetUpInGameData(int questionNumber)
        {
            InGameQuestions = GetRandomQuestions(questionNumber);
            Answers = new string[InGameQuestions.Length - 1];
            Highscore = 0;
            AnswerCount = 0;
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

            for (int i = 0; i < questionNumber - 1; i++)
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