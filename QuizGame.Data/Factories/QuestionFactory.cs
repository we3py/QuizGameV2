namespace QuizGame.Data.Factories
{
    public class QuestionFactory
    {
#pragma warning disable CA1822
        public Question GetNew(string query, string correctAnswer, params string[] answers)
#pragma warning restore CA1822
        {
            var question = new Question()
            {
                Query = query,
                CorrectAnswer = correctAnswer,
                AnswerA = answers[0],
                AnswerB = answers[1],
                AnswerC = answers[2],
                AnswerD = answers[3]
            };

            return question;
        }
    }
}
