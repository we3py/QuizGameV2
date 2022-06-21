using QuizGame.Data;

namespace QuizGame.Logic
{
    public interface IQuizManager
    {
        string[] Answers { get; set; }
        int Highscore { get; set; }
        Question[] InGameQuestions { get; set; }

        void CalculateHighscore();
        void SetUpAnswer(int answerIndex, string answer);
    }
}