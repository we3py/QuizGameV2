using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Data
{
    public class QuestionFactory
    {
        public Question GetNew(string query, string correctAnswer, params string[] answers)
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
