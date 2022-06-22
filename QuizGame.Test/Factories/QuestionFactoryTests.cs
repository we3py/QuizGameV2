using QuizGame.Data.Factories;

namespace QuizGame.Test.Factories
{
    [TestFixture]
    public class QuestionFactoryTests
    {


        [SetUp]
        public void SetUp()
        {

        }

        private QuestionFactory CreateFactory()
        {
            return new QuestionFactory();
        }

        [Test]
        public void GetNew_NullQueryValue_NotNullValue()
        {
            // Arrange
            var factory = this.CreateFactory();
            string query = null;
            string correctAnswer = "A";
            string[] answers = { "AA", "AB", "AC", "AD" };

            // Act
            var result = factory.GetNew(query, correctAnswer, answers);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void GetNew_TooFewAnswers_IndexOutOfRangeException()
        {
            // Arrange
            var factory = this.CreateFactory();
            string query = "Question";
            string correctAnswer = "A";
            string[] answers = { "AA", "AB", "AC" };

            // Act          

            // Assert
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                factory.GetNew(query, correctAnswer, answers);
            });
        }
        [Test]
        public void GetNew_TooManyAnswers_NotNullValue()
        {
            // Arrange
            var factory = this.CreateFactory();
            string query = "Question";
            string correctAnswer = "A";
            string[] answers = { "AA", "AB", "AC", "AD", "AE" };

            // Act          
            var result = factory.GetNew(query, correctAnswer, answers);
            // Assert
            Assert.That(result, Is.Not.Null);
        }
        [Test]
        public void GetNew_NullCorrectAnswerValue_NotNullValue()
        {
            // Arrange
            var factory = this.CreateFactory();
            string query = "question";
            string correctAnswer = null;
            string[] answers = { "AA", "AB", "AC", "AD" };

            // Act
            var result = factory.GetNew(query, correctAnswer, answers);

            // Assert
            Assert.That(result, Is.Not.Null);
        }
    }

}
/* Assert.Throws<NullReferenceException>(() =>
            {
                factory.GetNew(query, correctAnswer, answers);
            });*/