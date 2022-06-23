#pragma warning disable RCS1073
namespace QuizGame.Data.Validators
{
    public static class QuestionValidation
    {
        public static bool Validate(CsvReader dataToValidate)
        {
            if (CheckRequirements(dataToValidate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool CheckRequirements(CsvReader dataToValidate)
        {
            if (ValidateNumberOfFields(dataToValidate)
                && ValidateIfQuestionAlreadyExist(dataToValidate)
                && ValidateIfCorrectAnswerExist(dataToValidate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ValidateIfQuestionAlreadyExist(CsvReader dataToValidate)
        {
            var query = dataToValidate.GetField(0);
            int flagIfQuoteExist = 0;
            var existinQuestions = new RepositoryHandler().GetExistingQuestions();
            foreach (var question in existinQuestions)
            {
                if (string.Equals(query, question.Query))
                {
                    flagIfQuoteExist = 1;
                }
            }
            if (flagIfQuoteExist == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ValidateIfCorrectAnswerExist(CsvReader dataToValidate)
        {
            var correctAnswer = dataToValidate.GetField(5);
            if (correctAnswer.Equals("A") || correctAnswer.Equals("B") || correctAnswer.Equals("C") || correctAnswer.Equals("D"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ValidateNumberOfFields(CsvReader dataToValidate)
        {
            if (dataToValidate.Parser.Count == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
#pragma warning restore RCS1073
