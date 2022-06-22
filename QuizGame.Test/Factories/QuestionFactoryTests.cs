using NSubstitute;
using NUnit.Framework;
using QuizGame.Data.Factories;
using System;

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
        public void GetNew_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var factory = this.CreateFactory();
            string query = null;
            string correctAnswer = null;
            string[] answers = null;

            // Act
            var result = factory.GetNew(
                query,
                correctAnswer,
                answers);

            // Assert
            Assert.Fail();
        }
    }
}
