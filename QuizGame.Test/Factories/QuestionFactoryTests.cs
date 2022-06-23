namespace QuizGame.Test.Factories
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        private static QuestionFactory CreateFactory()
        {
            return new QuestionFactory();
        }

        [Test]
        public void GetNew_NullQueryValue_NotNullValue()
        {
            // Arrange
            var factory = CreateFactory();
            const string correctAnswer = "A";
            string[] answers = { "AA", "AB", "AC", "AD" };

            // Act
            var result = factory.GetNew(null!, correctAnswer, answers);

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void GetNew_TooFewAnswers_IndexOutOfRangeException()
        {
            // Arrange
            var factory = CreateFactory();
            const string query = "Question";
            const string correctAnswer = "A";
            string[] answers = { "AA", "AB", "AC" };

            // Act

            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => factory.GetNew(query, correctAnswer, answers));
        }
        [Test]
        public void GetNew_TooManyAnswers_NotNullValue()
        {
            // Arrange
            var factory = CreateFactory();
            const string query = "Question";
            const string correctAnswer = "A";
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
            var factory = CreateFactory();
            const string query = "question";
            string[] answers = { "AA", "AB", "AC", "AD" };

            // Act
            var result = factory.GetNew(query, null!, answers);

            // Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}
