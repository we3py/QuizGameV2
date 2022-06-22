using QuizGame.Data;

namespace QuizGame.Logic
{
    public interface IQuizManager
    {
        string[] Answers { get; set; }
        int Highscore { get; set; }
        List<Question> InGameQuestions { get; set; }
        bool IsPlaying { get; set; }
        int AnswerCount { get; set; }
        int QuestionNumber { get; set; }

        void CalculateHighscore();
        void SetUpAnswer(string answer);
        void ClearInGameData();
        void SetUpInGameData(int questionNumber);
    }
}