namespace QuizGame.Data
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Query { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string CorrectAnswer { get; set; }

    }
}