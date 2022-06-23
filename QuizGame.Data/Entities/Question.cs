namespace QuizGame.Data
{
#pragma warning disable CS0659
    public class Question
#pragma warning restore CS0659
    {
        public int QuestionId { get; set; }
#pragma warning disable CS8618
        public string Query { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string CorrectAnswer { get; set; }
#pragma warning restore CS8618

        public override string ToString()
        {
            return Query;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Question question) { return false; }

            return QuestionId == question.QuestionId;
        }
    }
}