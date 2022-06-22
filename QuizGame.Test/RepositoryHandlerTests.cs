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
            Assert.That(result.Count(), Is.EqualTo(expected.Count()));
            for (int i = 0; i < expected.Count(); i++)
            {
                Assert.That(expected[i].QuestionId, Is.EqualTo(result[i].QuestionId));
                Assert.That(expected[i].Query, Is.EqualTo(result[i].Query));
                Assert.That(expected[i].AnswerA, Is.EqualTo(result[i].AnswerA));
                Assert.That(expected[i].AnswerB, Is.EqualTo(result[i].AnswerB));
                Assert.That(expected[i].AnswerC, Is.EqualTo(result[i].AnswerC));
                Assert.That(expected[i].AnswerD, Is.EqualTo(result[i].AnswerD));
                Assert.That(expected[i].CorrectAnswer, Is.EqualTo(result[i].CorrectAnswer));
            }
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
            Assert.That(result.Count(), Is.EqualTo(expected.Count()));
            for (int i = 0; i < expected.Count(); i++)
            {
                Assert.That(expected[i].HighscoreId, Is.EqualTo(result[i].HighscoreId));
                Assert.That(expected[i].UserName, Is.EqualTo(result[i].UserName));
                Assert.That(expected[i].Score, Is.EqualTo(result[i].Score));
            }
        }
    }
}
