namespace QuizGame.Data
{
    public class Question
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

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}