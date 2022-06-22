using NSubstitute;
using NUnit.Framework;
using QuizGame.Data;
using System;

namespace QuizGame.Test
{
    [TestFixture]
    public class RepositoryHandlerTests
    {


        [SetUp]
        public void SetUp()
        {

        }

        private RepositoryHandler CreateRepositoryHandler()
        {
            return new RepositoryHandler();
        }

        [Test]
        public void AddQuestion_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var repositoryHandler = this.CreateRepositoryHandler();
            Question question = null;

            // Act
            repositoryHandler.AddQuestion(
                question);

            // Assert
            Assert.Fail();
        }

        [Test]
        public void GetExistingQuestions_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var repositoryHandler = this.CreateRepositoryHandler();

            // Act
            var result = repositoryHandler.GetExistingQuestions();

            // Assert
            Assert.Fail();
        }

        [Test]
        public void AddHighscore_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var repositoryHandler = this.CreateRepositoryHandler();
            string userName = null;
            int score = 0;

            // Act
            repositoryHandler.AddHighscore(
                userName,
                score);

            // Assert
            Assert.Fail();
        }

        [Test]
        public void GetHighscores_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var repositoryHandler = this.CreateRepositoryHandler();

            // Act
            var result = repositoryHandler.GetHighscores();

            // Assert
            Assert.Fail();
        }
    }
}
