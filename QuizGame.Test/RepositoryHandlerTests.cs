using Microsoft.EntityFrameworkCore;
using QuizGame.Data;

namespace QuizGame.Test
{
    [TestFixture]
    public class RepositoryHandlerTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        private static RepositoryHandler CreateRepositoryHandler()
        {
            return new RepositoryHandler();
        }

        [Test]
        public void AddQuestion_QuestionIsNull_ThrowNullReferenceException()
        {
            // Arrange
            var repositoryHandler = CreateRepositoryHandler();

            // Act

            // Assert
            Assert.Throws<NullReferenceException>(() => repositoryHandler.AddQuestion(null));
        }

        [Test]
        public void GetExistingQuestions_GetListOfQuestions_CorrectListOfQuestions()
        {
            // Arrange
            var repositoryHandler = CreateRepositoryHandler();
            var context = new QuizGameContext();
            var expected = context.Questions.ToList();

            // Act
            var result = repositoryHandler.GetExistingQuestions();

            // Assert
            Assert.That(result, Has.Count.EqualTo(expected.Count));
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Multiple(() =>
                {
                    Assert.That(expected[i].QuestionId, Is.EqualTo(result[i].QuestionId));
                    Assert.That(expected[i].Query, Is.EqualTo(result[i].Query));
                    Assert.That(expected[i].AnswerA, Is.EqualTo(result[i].AnswerA));
                    Assert.That(expected[i].AnswerB, Is.EqualTo(result[i].AnswerB));
                    Assert.That(expected[i].AnswerC, Is.EqualTo(result[i].AnswerC));
                    Assert.That(expected[i].AnswerD, Is.EqualTo(result[i].AnswerD));
                    Assert.That(expected[i].CorrectAnswer, Is.EqualTo(result[i].CorrectAnswer));
                });
            }
        }

        [Test]
        public void AddHighscore_UserNameNull_DbUpdateException()
        {
            // Arrange
            var repositoryHandler = CreateRepositoryHandler();
            const int score = 0;

            // Act

            // Assert
            Assert.Throws<DbUpdateException>(() => repositoryHandler.AddHighscore(null, score));
        }

        [Test]
        public void GetHighscores_GetListOfHighscores_CorrectListOfHighScores()
        {
            // Arrange
            var repositoryHandler = CreateRepositoryHandler();
            var context = new QuizGameContext();
            var expected = context.Highscores.ToList();

            // Act
            var result = repositoryHandler.GetHighscores();

            // Assert
            Assert.That(result, Has.Count.EqualTo(expected.Count));
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.That(expected[i].HighscoreId, Is.EqualTo(result[i].HighscoreId));
                Assert.Multiple(() =>
                {
                    Assert.That(expected[i].UserName, Is.EqualTo(result[i].UserName));
                    Assert.That(expected[i].Score, Is.EqualTo(result[i].Score));
                });
            }
        }
    }
}
