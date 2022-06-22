using Microsoft.EntityFrameworkCore;
using NSubstitute;
using NUnit.Framework;
using QuizGame.Data;
using QuizGame.Data.Entities;
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
        public void AddQuestion_QuestionIsNull_ThrowNullReferenceException()
        {
            // Arrange
            var repositoryHandler = this.CreateRepositoryHandler();
            Question question = null;

            // Act

            // Assert
            Assert.Throws<NullReferenceException>(() => repositoryHandler.AddQuestion(question));
        }

        [Test]
        public void GetExistingQuestions_GetListOfQuestions_CorrectListOfQuestions()
        {
            // Arrange
            var repositoryHandler = this.CreateRepositoryHandler();
            var context = new QuizGameContext();
            var expected = context.Questions.ToList();

            // Act
            var result = repositoryHandler.GetExistingQuestions();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddHighscore_UserNameNull_DbUpdateException()
        {
            // Arrange
            var repositoryHandler = this.CreateRepositoryHandler();
            string userName = null;
            int score = 0;

            // Act

            // Assert
            Assert.Throws<DbUpdateException>(() => repositoryHandler.AddHighscore(userName, score));
        }

        [Test]
        public void GetHighscores_GetListOfHighscores_CorrectListOfHighScores()
        {
            // Arrange
            var repositoryHandler = this.CreateRepositoryHandler();
            var context = new QuizGameContext();
            var expected = context.Highscores.ToList();

            // Act
            var result = repositoryHandler.GetHighscores();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
