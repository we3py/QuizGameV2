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

        public override string ToString()
        {
            return Query;
        }

        public override bool Equals(object? obj)
        {
            var question = obj as Question;
            if (question == null) { return false; }

            return this.QuestionId == question.QuestionId ? true : false;
        }

    }
}