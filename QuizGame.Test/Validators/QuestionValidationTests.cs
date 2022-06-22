using CsvHelper;
using QuizGame.Data.Validators;

namespace QuizGame.Test.Validators
{
    [TestFixture]
    public class QuestionValidationTests
    {




        [Test]
        public void Validate_NullDataToValidate_NullReferenceException()
        {
            // Arrange

            CsvReader dataToValidate = null;

            // Act


            // Assert
            Assert.Throws<NullReferenceException>(
      () => { QuestionValidation.Validate(dataToValidate); });
        }
    }
}
