using QuizGame.Data;

namespace QuizGame.Logic
{
    public class QuizManager : IQuizManager
    {
        private IRepositoryHandler _repositoryHandler;
        public List<Question> InGameQuestions { get; set; }
        public string[] Answers { get; set; }
        public int Highscore { get; set; }
        public bool IsPlaying { get; set; }
        public int AnswerCount { get; set; }
        public int QuestionNumber { get; set; }

        public QuizManager(IRepositoryHandler repositoryHandler, int questionNumber)
        {
            _repositoryHandler = repositoryHandler;
            QuestionNumber = questionNumber;
            InGameQuestions = new List<Question>();
        }

        #region Public methods

        public void SetUpAnswer(string answer)
        {
            if (AnswerCount > InGameQuestions.Count - 1) 
            { 
                IsPlaying = false;
                return;
            }

            
            Answers[AnswerCount] = answer;
            AnswerCount++;

            if (AnswerCount == InGameQuestions.Count) 
            { 
                IsPlaying = false;
                AnswerCount--;
            }
            
        }

        public void CalculateHighscore()
        {
            Highscore = 0;
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
            Answers = null;
            Highscore = 0;
            AnswerCount = 0;
        }

        public void SetUpInGameData(int questionNumber)
        {
            ClearInGameData();
            InGameQuestions = GetRandomQuestions(questionNumber);
            Answers = new string[InGameQuestions.Count];
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
        
        private List<Question> GetRandomQuestions(int questionNumber)
        {
            Question randomQuestion = new Question();
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